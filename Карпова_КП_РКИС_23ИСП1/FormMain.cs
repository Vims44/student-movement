using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Карпова_КП_РКИС_23ИСП1.Controller;

namespace Карпова_КП_РКИС_23ИСП1
{
    public partial class FormMain : Form
    {
        Query controller;

        public FormMain()
        {
            InitializeComponent();
            controller = new Query(AppSetting.ConnStr);
            // Подписываемся на выбор строки в таблице студентов
            dataGridViewMovement.SelectionChanged += dataGridViewMovement_SelectionChanged;

            FillTableStudents();
            FillTableGraduates();
            FillTableApplicants();
            FillTableMovement();           
            dataGridViewMoveStud.DataSource = null; // Очистка таблицы
            label5.Text = "Выберите студента";
        }

        // Нажатие на справочники-группа в главной форме
        private void группаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSprav formSprav = new FormSprav();
            formSprav.Show();
        }

        // Нажатие на справочники-статус в главной форме
        private void статусToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSprav formSprav = new FormSprav();
            formSprav.Show();
            formSprav.tabctrlMain.SelectedIndex = 1;   // Вторая вкладка
        }

        // Метод заполнения таблицы студенты
        private void FillTableStudents(string query = "")
        {
            DataTable dt = controller.Student(query);
            dataGridViewStudents.DataSource = dt;
            dataGridViewStudents.Columns["Номер"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            toolStripLabelStudent.Text = $"Количество записей: {dt.Rows.Count}";
        }

        // Метод заполнения таблицы выпускники
        private void FillTableGraduates(string query = "")
        {
            DataTable dt = controller.Graduate(query);
            dataGridViewGraduates.DataSource = dt;
            dataGridViewGraduates.Columns["Номер"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            toolStripLabelGraduate.Text = $"Количество записей: {dt.Rows.Count}";
        }

        // Метод заполнения таблицы абитуриенты
        private void FillTableApplicants(string query = "")
        {
            DataTable dt = controller.Applicant(query);
            dataGridViewApplicants.DataSource = dt;
            dataGridViewApplicants.Columns["Номер"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            toolStripLabelApplicants.Text = $"Количество записей: {dt.Rows.Count}";
        }

        // Метод заполнения таблицы движение студентов
        private void FillTableMovement(string query = "")
        {
            DataTable dt = controller.Movement(query);
            dataGridViewMovement.DataSource = dt;
            toolStripLabelMovement.Text = $"Количество записей: {dt.Rows.Count}";
        }

        // Нажатие на Приказ в меню
        private void приказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.Show();
        }

        // Кнопка изменить статус студента
        private void buttonStatusChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow == null)
            {
                MessageBox.Show("Выберите студента!");
                return;
            }
            string studentId = dataGridViewStudents.CurrentRow.Cells["Номер"].Value.ToString(); // Номер студенческого
            FormChangeStatus form = new FormChangeStatus(studentId);
            form.ShowDialog(); 
            // Обновление таблиц после изменения
            FillTableStudents();
            FillTableMovement();
        }

        // Главная форма
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // Заполнение ComboBox из базы
            FillComboBoxes();

            // Загрузка таблиц
            FillTableStudents();
            FillTableGraduates();
            FillTableApplicants();
            FillTableMovement();
        }

        // Данные для comboBox из таблиц
        private void FillComboBoxes()
        {
            try
            {
                // Статусы студентов 
                comboBoxStatus.Items.Clear();
                var statuses = controller.GetComboBoxItems("Status", "Nazv_statusa");
                comboBoxStatus.Items.AddRange(statuses.ToArray());
                if (statuses.Count > 0) comboBoxStatus.SelectedIndex = -1; // Ничего не выбрано

                // Группы 
                comboBoxGroup.Items.Clear();
                var groups = controller.GetComboBoxItems("Group", "Shifr_gr");
                comboBoxGroup.Items.AddRange(groups.ToArray());

                // Специальности
                comboBoxSpec.Items.Clear();
                var specs = controller.GetComboBoxItems("Speciality", "Nazvanie");
                comboBoxSpec.Items.AddRange(specs.ToArray());

                // Форма оплаты 
                comboBoxPayment.Items.Clear();
                string sqlPayment = "SELECT DISTINCT Form_opl FROM Student WHERE Form_opl IS NOT NULL AND Form_opl <> '' ORDER BY Form_opl";
                using (var cmd = new SQLiteCommand(sqlPayment, controller.Connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string val = reader["Form_opl"]?.ToString().Trim();
                        if (!string.IsNullOrEmpty(val))
                            comboBoxPayment.Items.Add(val);
                    }
                }

                comboBoxCours.Items.Clear();
                for (int i = 1; i <= 6; i++)
                    comboBoxCours.Items.Add(i.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке списков: " + ex.Message);
            }
        }

        // Кнопка очистка поиска
        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            textBoxStudFIO.Clear();
            textBoxAge.Clear();
            comboBoxCours.SelectedIndex = -1;
            comboBoxGroup.SelectedIndex = -1;
            comboBoxPayment.SelectedIndex = -1;
            comboBoxSpec.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
            FillTableStudents();
        }

        // Кнопка поиск 
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string fio = textBoxStudFIO.Text.Trim();

            // Обработка возраста
            string ageText = textBoxAge.Text.Trim();
            int? age = null;
            string ageCondition = null;

            if (!string.IsNullOrEmpty(ageText))
            {
                var match = System.Text.RegularExpressions.Regex.Match(ageText, @"^([<>=]+)?\s*(\d+)$");
                if (match.Success)
                {
                    string op = match.Groups[1].Value;
                    int value = int.Parse(match.Groups[2].Value);

                    if (string.IsNullOrEmpty(op) || op == "=")
                        age = value; // Точное совпадение
                    else
                        ageCondition = op + value.ToString(); // С использованием знаков
                }
                else
                {
                    MessageBox.Show("Неверный формат возраста!\nПримеры: 18, <18, <=17", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Курс
            int? course = null;
            if (int.TryParse(comboBoxCours.Text, out int c))
                course = c;

            // Вызов поиска
            DataTable dt = controller.StudentSearch(
                fio: string.IsNullOrWhiteSpace(fio) ? null : fio,
                status: comboBoxStatus.Text,
                group: comboBoxGroup.Text,
                speciality: comboBoxSpec.Text,
                paymentForm: comboBoxPayment.Text,
                course: course,
                age: age,
                ageCondition: ageCondition  
            );

            dataGridViewStudents.DataSource = dt;
            toolStripLabelStudent.Text = $"Количество записей: {dt.Rows.Count}";
        }

        // Разрешение ввода возраст
        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешено цифры, < > = Backspace и пробел
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != '<' &&
                e.KeyChar != '>' &&
                e.KeyChar != '=' &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != ' ')
            {
                e.Handled = true; // Блокировка ввода
            }
        }

        // Разрешение ввода фио
        private void textBoxStudFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешено буквы , пробел, дефис, Backspace
            if (!char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ' &&
                e.KeyChar != '-' &&
                e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // Запреты для комбобоксов
        private void comboBoxGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBoxSpec_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBoxCours_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBoxStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBoxPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Кнопка выпуск
        private void buttonGraduate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0 && dataGridViewStudents.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выделите хотя бы одного студента!", "Внимание",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIds = new HashSet<long>();
            foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
                if (long.TryParse(row.Cells["Номер"].Value?.ToString(), out long id))
                    selectedIds.Add(id);

            foreach (DataGridViewCell cell in dataGridViewStudents.SelectedCells)
                if (long.TryParse(cell.OwningRow.Cells["Номер"].Value?.ToString(), out long id))
                    selectedIds.Add(id);

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Не удалось определить номера студентов.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DateTime today = DateTime.Today;

                var result = controller.GraduateStudents(selectedIds, today);

                FillTableStudents();
                FillTableGraduates();
                FillTableMovement();

                if (result.Graduated == 0)
                {
                    MessageBox.Show(
                        "Ни один студент не был выпущен.\n\n" +
                        "Все выделенные студенты уже имеют статус «Выпускник».",
                        "Действие не требуется",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Номер приказа — берём через метод (гарантированно правильный)
                int orderNum = controller.GetNextGraduateOrderNumber(today.Year);

                MessageBox.Show(
                    $"Выпуск успешно завершён!\n\n" +
                    $"Выпущено студентов: {result.Graduated}\n" +
                    (result.Skipped > 0 ? $"Пропущено (уже выпускники): {result.Skipped}\n" : "") +
                    $"Создан приказ № {orderNum}-В от {today:dd.MM.yyyy}",
                    "Готово!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выпуске студентов:\n" + ex.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Нажатие на отчёты
        private void отчётыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReports formReport = new FormReports();
            formReport.Show();
        }

        // Таблица движение студентов
        private void dataGridViewMovement_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMovement.SelectedRows.Count > 0)
            {
                var row = dataGridViewMovement.SelectedRows[0];
                string fio = row.Cells["ФИО студента"].Value?.ToString() ?? "Неизвестно";
                string idStr = row.Cells["Номер студенческого"].Value?.ToString();
                if (long.TryParse(idStr, out long studentId))
                {
                    label5.Text = $"Приказы студента: {fio} (№ {studentId})";
                    DataTable dt = controller.GetAllOrdersByStudent(studentId);
                    dataGridViewMoveStud.DataSource = dt;
                    toolStripLabel1.Text = $"Количесвто записей: {dt.Rows.Count}";
                }
                else
                {
                    label5.Text = "Ошибка чтения данных";
                    dataGridViewMoveStud.DataSource = null;
                }
            }
            else
            {
                label5.Text = "Выберите запись выше";
                dataGridViewMoveStud.DataSource = null;
            }
        }

        // Кнопка зачислить
        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplicants.SelectedRows.Count == 0 && dataGridViewApplicants.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выделите хотя бы одного абитуриента!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Собираем уникальные ID выделенных абитуриентов
            var selectedIds = new HashSet<long>();
            foreach (DataGridViewRow row in dataGridViewApplicants.SelectedRows)
                if (long.TryParse(row.Cells["Номер"].Value?.ToString(), out long id))
                    selectedIds.Add(id);

            foreach (DataGridViewCell cell in dataGridViewApplicants.SelectedCells)
                if (long.TryParse(cell.OwningRow.Cells["Номер"].Value?.ToString(), out long id))
                    selectedIds.Add(id);

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("Не удалось определить номера абитуриентов.", "Ошибка");
                return;
            }

            // Фильтруем только со статусом "Подан"
            var validForEnroll = new List<(long Id, string FIO, string SpecName)>();
            var skipped = new List<string>();

            foreach (DataGridViewRow row in dataGridViewApplicants.Rows)
            {
                if (!selectedIds.Contains(Convert.ToInt64(row.Cells["Номер"].Value ?? 0))) continue;

                string status = row.Cells["Статус"].Value?.ToString() ?? "";
                string fio = row.Cells["ФИО"].Value?.ToString() ?? "Без имени";
                string spec = row.Cells["Специальность"].Value?.ToString() ?? "";

                if (status == "Подан")
                    validForEnroll.Add((Convert.ToInt64(row.Cells["Номер"].Value), fio, spec));
                else
                    skipped.Add($"{fio} — статус: {status}");
            }

            if (validForEnroll.Count == 0)
            {
                MessageBox.Show("Нет абитуриентов со статусом «Подан» среди выделенных!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (skipped.Count > 0)
            {
                MessageBox.Show("Пропущены студенты со статусом 'Зачислен'", "Пропущено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (MessageBox.Show($"Зачислить {validForEnroll.Count} абитуриент(ов) на 1 курс?\n\n" +
                                "Группы будут созданы автоматически.",
                                "Подтверждение зачисления",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                DateTime today = DateTime.Today;
                int currentYear = today.Year;
                string yearPrefix = (currentYear % 100).ToString("D2"); // 25 для 2025

                // Один общий приказ
                string comment = $"Зачисление {validForEnroll.Count} чел. на обучение ({currentYear} г.)";
                long orderId = controller.AddOrder("О зачислении на обучение", today, comment);

                using (var transaction = controller.Connection.BeginTransaction())
                {
                    foreach (var (appId, fio, specName) in validForEnroll)
                    {
                        var appData = controller.GetApplicantForEnroll(appId);
                        if (appData.Rows.Count == 0) continue;
                        var dr = appData.Rows[0];

                        string birth = dr["Date_birthday"]?.ToString() ?? "";
                        string addr = dr["Address"]?.ToString() ?? "";
                        string phone = dr["Phone"]?.ToString() ?? "";
                        double avgScore = Convert.ToDouble(dr["Average_score"] ?? 0);
                        string shifrSpec = dr["Shifr_spec"]?.ToString() ?? "";
                        string abbreviation = dr["Sokrashenie"]?.ToString()?.Trim().ToUpper() ?? "ИСП";

                        string groupCode = yearPrefix + abbreviation;  

                        controller.EnsureGroupExists(groupCode, currentYear, shifrSpec);

                        long newStudentId = controller.AddStudentFromApplicant(
                            fio, birth, addr, phone, groupCode, avgScore);
                        controller.ExecuteNonQuery("UPDATE Statement SET Status = 'Зачислен' WHERE [Number_ applicant] = @id",("@id", appId));

                        controller.ExecuteNonQuery(@"INSERT INTO Student_movement 
                                                  (Student_ID, Order_ID, Order_Action, Order_Effective_Date)
                                                  VALUES (@student, @order, 'Зачислен на 1 курс', @date)",
                                                 ("@student", newStudentId),
                                                 ("@order", orderId),
                                                 ("@date", today));
                    }
                    transaction.Commit();
                }

                // Обновляем всё
                FillTableApplicants();
                FillTableStudents();
                FillTableMovement();

                MessageBox.Show($"Зачисление успешно!\n" +
                                $"Создан приказ о зачислении.\n" +
                                $"Зачислено студентов: {validForEnroll.Count}",
                                "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при зачислении:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Выход из программы
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из программы?",
                        "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = "Подсистема учёта движения студентов\n\n" +
                   "Версия: 1.0\n" +
                   "Дата выпуска: ноябрь 2025\n" +
                   "Разработчик: Карпова Анна Сергеевна\n" +
                   "Группа 23ИСП1\n" +
                   "Орский гуманитарно-технологический институт (филиал) ОГУ\n\n" +
                   "GitHub: https://github.com/Vims44/student-movement";
            MessageBox.Show(about, "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
