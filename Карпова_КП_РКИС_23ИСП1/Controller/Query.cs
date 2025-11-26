using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Карпова_КП_РКИС_23ИСП1.Controller
{
    class Query
    {
        // Данные класса
        SQLiteConnection connection;
        SQLiteCommand command;
        SQLiteDataAdapter dataAdapter;
        DataTable buferTable;

        private const string AgeExpression = @"CAST(
        (strftime('%Y', 'now') - strftime('%Y', substr(s.Data_rojd, 7, 4) || '-' || substr(s.Data_rojd, 4, 2) || '-' || substr(s.Data_rojd, 1, 2)))
        - (strftime('%m-%d', 'now') < strftime('%m-%d', substr(s.Data_rojd, 7, 4) || '-' || substr(s.Data_rojd, 4, 2) || '-' || substr(s.Data_rojd, 1, 2)))
    AS INTEGER)";

        // Конструктор класса
        public Query(string conn)
        {
            connection = new SQLiteConnection(conn);
            connection.Open();
        }
        public SQLiteConnection Connection => connection;

        // Возвращает общую таблицу
        public DataTable Total(string query)
        {
            buferTable = new DataTable();
            string querytotal = query;
            dataAdapter = new SQLiteDataAdapter(querytotal, connection);
            dataAdapter.Fill(buferTable);
            return buferTable;
        }

        // Добавление/Редактирование статуса
        public void ModifyStatus(int mode, string newValue, string oldValue = "")
        {
            string query = "";
            try
            {
                if (mode == 0) // Добавление
                {
                    query = "INSERT INTO Status (Nazv_statusa) VALUES (@name)";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", newValue);
                        command.ExecuteNonQuery();
                    }
                }
                else if (mode == 1) // Редактирование
                {
                    query = "UPDATE Status SET Nazv_statusa = @new WHERE Nazv_statusa = @old";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@new", newValue);
                        command.Parameters.AddWithValue("@old", oldValue);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                throw new Exception("Статус с таким названием уже существует!");
            }
        }

        // Метод для проверки активных студентов
        public bool IsStatusUsedInActiveStudents(string statusName)
        {
            string query = "SELECT COUNT(*) FROM Student WHERE Nazv_statusa = @name";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@name", statusName);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        // Удаление статуса (перегрузка)
        public void DeleteStatus(string value)
        {
            if (IsStatusUsedInActiveStudents(value))
            {
                throw new Exception($"Нельзя удалить статус «{value}» — он используется у текущих студентов!");
            }
            string query = "DELETE FROM Status WHERE Nazv_statusa = @name";
            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@name", value);
                cmd.ExecuteNonQuery();
            }
        }

        // Запрос для студентов
        public DataTable Student(string query = "")
        {
            buferTable = new DataTable();
            string totalStudent = $@"SELECT
                                    s.Nom_stud AS 'Номер',
                                    s.FIO AS 'ФИО',
                                    s.Data_rojd AS 'Дата рождения',
                                    ({AgeExpression}) AS 'Возраст',
                                    s.Adress AS 'Адрес',
                                    s.Telefon AS 'Телефон',
                                    s.Shifr_gr AS 'Группа',
                                    g.God_post AS 'Год поступления',
                                    g.God_okon AS 'Год окончания',
                                    (strftime('%Y','now') - g.God_post + CASE WHEN strftime('%m','now') >= '09' THEN 1 ELSE 0 END) AS 'Курс',
                                    sp.Nazvanie AS 'Специальность',
                                    s.Nazv_statusa AS 'Статус',
                                    s.Form_opl AS 'Форма оплаты',
                                    s.Sred_ball_attes AS 'Средний балл'
                                FROM Student s
                                LEFT JOIN ""Group"" g ON s.Shifr_gr = g.Shifr_gr
                                LEFT JOIN Speciality sp ON g.Shifr_spec = sp.Shifr_spec
                                {query}
                                ORDER BY s.FIO";
            dataAdapter = new SQLiteDataAdapter(totalStudent, connection);
            dataAdapter.Fill(buferTable);
            return buferTable;
        }

        // Запрос для выпускникоа
        public DataTable Graduate(string query = "")
        {
            buferTable = new DataTable();

            string totalGraduate = @"SELECT 
                                    s.Nom_stud AS 'Номер',
                                    s.FIO AS 'ФИО',
                                    s.Data_rojd AS 'Дата рождения',
                                    s.Adress AS 'Адрес',
                                    s.Telefon AS 'Телефон',
                                    s.Shifr_gr AS 'Группа',
                                    g.God_post AS 'Год поступления',
                                    g.God_okon AS 'Год окончания',
                                    sp.Nazvanie AS 'Специальность',
                                    s.Nazv_statusa AS 'Статус',
                                    s.Form_opl AS 'Форма оплаты',
                                    s.Sred_ball_attes AS 'Средний балл'
                                FROM Student s
                                LEFT JOIN ""Group"" g ON s.Shifr_gr = g.Shifr_gr
                                LEFT JOIN Speciality sp ON g.Shifr_spec = sp.Shifr_spec
                                WHERE s.Nazv_statusa = 'Выпускник'
                                " + query + @"
                                ORDER BY s.FIO";
            dataAdapter = new SQLiteDataAdapter(totalGraduate, connection);
            dataAdapter.Fill(buferTable);
            return buferTable;
        }

        // Запрос для абитуриентов
        public DataTable Applicant(string query = "")
        {
            buferTable = new DataTable();
            string totalApplicant = @"SELECT 
                                    a.[Number_ applicant] AS 'Номер',
                                    a.FIO AS 'ФИО',
                                    a.Gender AS 'Пол',
                                    a.Date_birthday AS 'Дата рождения',
                                    a.Address AS 'Адрес',
                                    a.Phone AS 'Телефон',
                                    a.School AS 'Школа',
                                    a.[Number_ certificate] AS 'Номер сертификата',
                                    a.Average_score AS 'Средний балл',
                                    a.Preferential_category AS 'Льготы',
                                    a.Medical_certificate AS 'Мед. справка',
                                    s.Status AS 'Статус',
                                    sp.Nazvanie AS 'Специальность'
                                FROM Applicant a
                                LEFT JOIN Statement st ON a.[Number_ applicant] = st.[Number_ applicant]
                                LEFT JOIN Statuses s ON st.Status = s.Status
                                LEFT JOIN Speciality sp ON st.Shifr_spec = sp.Shifr_spec
                                " + query + @"
                                ORDER BY a.FIO;";
            dataAdapter = new SQLiteDataAdapter(totalApplicant, connection);
            dataAdapter.Fill(buferTable);
            return buferTable;
        }

        // Запрос для движения студентов по приказам
        public DataTable Movement(string query = "")
        {
            buferTable = new DataTable();
            string totalMovement = @"SELECT 
                                    Student_ID AS 'Номер студенческого',
                                    Order_ID AS 'Идентификатор приказа',
                                    Order_Action AS 'Действие по приказу',
                                    Order_Effective_Date AS 'Дата вступления приказа'
                                FROM Student_movement
                                " + query + @"
                                ORDER BY Order_Effective_Date DESC";
            dataAdapter = new SQLiteDataAdapter(totalMovement, connection);
            dataAdapter.Fill(buferTable);
            return buferTable;
        }

        // Запрос для приказов
        public DataTable Orders(string query = "")
        {
            buferTable = new DataTable();
            string totalOrders = @"SELECT 
                                    Order_ID AS 'Идентификатор приказа',
                                    Order_Date AS 'Дата приказа',
                                    Order_Type AS 'Тип приказа',
                                    Comment AS 'Комментарий'
                                FROM Orders
                                " + query + @"
                                ORDER BY Order_Date DESC";
            dataAdapter = new SQLiteDataAdapter(totalOrders, connection);
            dataAdapter.Fill(buferTable);
            return buferTable;
        }

        // Метод для выполнения INSERT/UPDATE/DELETE
        public long ExecuteNonQuery(string sql, string param1Name = "", object param1Value = null,
                                                     string param2Name = "", object param2Value = null,
                                                     string param3Name = "", object param3Value = null,
                                                     string param4Name = "", object param4Value = null)
        {
            using (SQLiteCommand cmd = new SQLiteCommand(sql, connection))
            {
                if (!string.IsNullOrEmpty(param1Name)) cmd.Parameters.AddWithValue(param1Name, param1Value);
                if (!string.IsNullOrEmpty(param2Name)) cmd.Parameters.AddWithValue(param2Name, param2Value);
                if (!string.IsNullOrEmpty(param3Name)) cmd.Parameters.AddWithValue(param3Name, param3Value);
                if (!string.IsNullOrEmpty(param4Name)) cmd.Parameters.AddWithValue(param4Name, param4Value);
                cmd.ExecuteNonQuery();
                return connection.LastInsertRowId;
            }
        }

        // Поиск студентов с фильтрами (все параметры опциональные)
        public DataTable StudentSearch(
            string fio = null,
            string status = null,
            string group = null,
            string speciality = null,
            string paymentForm = null,
            int? course = null,
            string ageCondition = null,
            int? age = null)
        {
            buferTable = new DataTable();

            string baseQuery = $@"SELECT
                                s.Nom_stud AS 'Номер',
                                s.FIO AS 'ФИО',
                                s.Data_rojd AS 'Дата рождения',
                                ({AgeExpression}) AS 'Возраст',
                                s.Adress AS 'Адрес',
                                s.Telefon AS 'Телефон',
                                s.Shifr_gr AS 'Группа',
                                g.God_post AS 'Год поступления',
                                g.God_okon AS 'Год окончания',
                                sp.Nazvanie AS 'Специальность',
                                s.Nazv_statusa AS 'Статус',
                                s.Form_opl AS 'Форма оплаты',
                                (strftime('%Y','now') - g.God_post + CASE WHEN strftime('%m','now') >= '09' THEN 1 ELSE 0 END) AS 'Курс',
                                s.Sred_ball_attes AS 'Средний балл'
                            FROM Student s
                            LEFT JOIN ""Group"" g ON s.Shifr_gr = g.Shifr_gr
                            LEFT JOIN Speciality sp ON g.Shifr_spec = sp.Shifr_spec";

            List<string> conditions = new List<string>();
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            // Возраст с условием
            if (!string.IsNullOrEmpty(ageCondition))
            {
                conditions.Add($"({AgeExpression}) {ageCondition}");
            }
            else if (age.HasValue)
            {
                conditions.Add($"({AgeExpression}) = @age");
                parameters.Add("@age", age.Value);
            }

            // ФИО
            if (!string.IsNullOrWhiteSpace(fio))
            {
                conditions.Add("s.FIO LIKE @fio");
                parameters.Add("@fio", "%" + fio + "%");
            }

            // Статус
            if (!string.IsNullOrWhiteSpace(status))
            {
                conditions.Add("s.Nazv_statusa = @status");
                parameters.Add("@status", status);
            }

            // Группа
            if (!string.IsNullOrWhiteSpace(group))
            {
                conditions.Add("s.Shifr_gr = @group");
                parameters.Add("@group", group);
            }

            // Специальность
            if (!string.IsNullOrWhiteSpace(speciality))
            {
                conditions.Add("sp.Nazvanie = @spec");
                parameters.Add("@spec", speciality);
            }

            // Форма оплаты
            if (!string.IsNullOrWhiteSpace(paymentForm))
            {
                conditions.Add("s.Form_opl = @payment");
                parameters.Add("@payment", paymentForm);
            }

            // Курс
            if (course.HasValue)
            {
                conditions.Add($@"
        (strftime('%Y','now') - g.God_post + 
         CASE WHEN strftime('%m','now') >= '09' THEN 1 ELSE 0 END) = @course");
                parameters.Add("@course", course.Value);
            }

            // Финальный запрос
            string whereClause = conditions.Count > 0
                ? "WHERE " + string.Join(" AND ", conditions)
                : "";

            string finalQuery = baseQuery + " " + whereClause + " ORDER BY s.FIO";

            using (var cmd = new SQLiteCommand(finalQuery, connection))
            {
                foreach (var p in parameters)
                    cmd.Parameters.AddWithValue(p.Key, p.Value);

                dataAdapter = new SQLiteDataAdapter(cmd);
                dataAdapter.Fill(buferTable);
            }

            return buferTable;
        }

        // Для ComboBox — возвращает список строк 
        public List<string> GetComboBoxItems(string tableName, string columnName)
        {
            var items = new List<string>();
            string sql = $"SELECT {columnName} FROM \"{tableName}\" ORDER BY {columnName}";

            using (var cmd = new SQLiteCommand(sql, connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string value = reader[columnName]?.ToString();
                    if (!string.IsNullOrWhiteSpace(value))
                        items.Add(value.Trim());
                }
            }
            return items;
        }


        // ПРИКАЗЫ
        // Добавление нового приказа
        public long AddOrder(string orderType, DateTime orderDate, string comment = "")
        {
            string sql = @"INSERT INTO Orders (Order_Type, Order_Date, Comment)
                   VALUES (@type, @date, @comment)";
            return ExecuteNonQuery(sql,
                "@type", orderType,
                "@date", orderDate.ToString("yyyy-MM-dd"),
                "@comment", string.IsNullOrWhiteSpace(comment) ? (object)DBNull.Value : comment);
        }

        // Редактирование существующего приказа
        public void UpdateOrder(long orderId, string orderType, DateTime orderDate, string comment = "")
        {
            string sql = @"UPDATE Orders 
                   SET Order_Type = @type, 
                       Order_Date = @date, 
                       Comment = @comment 
                   WHERE Order_ID = @id";
            ExecuteNonQuery(sql,
                "@type", orderType,
                "@date", orderDate.ToString("yyyy-MM-dd"),
                "@comment", string.IsNullOrWhiteSpace(comment) ? (object)DBNull.Value : comment,
                "@id", orderId);
        }

        // Проверка: используется ли приказ в движениях студентов
        public bool IsOrderUsed(long orderId)
        {
            string sql = "SELECT COUNT(*) FROM Student_movement WHERE Order_ID = @id";
            using (var cmd = new SQLiteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@id", orderId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        // Удаление приказа (если не используется)
        public void DeleteOrder(long orderId)
        {
            if (IsOrderUsed(orderId))
                throw new Exception("Нельзя удалить приказ — он уже применён к студентам!");

            string sql = "DELETE FROM Orders WHERE Order_ID = @id";
            ExecuteNonQuery(sql, "@id", orderId);
        }
    }
}

