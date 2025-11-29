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
    public partial class FormChangeStatus : Form
    {
        private string studentId;
        Query controller;
        private long selectedOrderId = -1; // Выбранный ID приказа

        public FormChangeStatus(string nomStud)
        {
            InitializeComponent();
            this.studentId = nomStud;
            controller = new Query(AppSetting.ConnStr);
            LoadStudentInfo();
            LoadStatuses();
            LoadOrdersComboBox(); // Загрузка приказов
            dateTimePickerChange.Value = DateTime.Today;
        }

        // Загрузка информации о студентах
        private void LoadStudentInfo()
        {
            DataTable dt = controller.Total($@"
            SELECT FIO, Data_rojd, Shifr_gr, Nazv_statusa
            FROM Student
            WHERE Nom_stud = '{studentId}'");

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                labelfio.Text = "ФИО студента: " + row["FIO"].ToString();
                lblBirthDate.Text = "Дата рождения: " + Convert.ToDateTime(row["Data_rojd"]).ToString("dd.MM.yyyy");
                lblGroup.Text = "Группа: " + row["Shifr_gr"].ToString();
                comboBoxStatus.Text = row["Nazv_statusa"].ToString();
            }
        }

        // Загрузка статусов
        private void LoadStatuses()
        {
            comboBoxStatus.Items.Clear();
            DataTable statuses = controller.Total("SELECT Nazv_statusa FROM Status ORDER BY Nazv_statusa");
            foreach (DataRow row in statuses.Rows)
                comboBoxStatus.Items.Add(row["Nazv_statusa"].ToString());
        }

        // Загрузка приказов в ComboBox
        private void LoadOrdersComboBox(string filterType = null)
        {
            comboBoxOrder.DataSource = null;
            comboBoxOrder.Items.Clear();

            string sql = @"
        SELECT 
            Order_ID AS Value,
            (Order_Type || ' от ' || date(Order_Date, 'localtime') || 
             CASE WHEN Comment IS NOT NULL AND Comment != '' AND Comment != 'Изменение статуса' 
                  THEN ' — ' || Comment ELSE '' END) AS Text
        FROM Orders 
        WHERE Order_Type IS NOT NULL AND Order_Type != ''
        " + (filterType != null ? " AND Order_Type LIKE @filter" : "") + @"
        ORDER BY Order_Date DESC";

            using (var cmd = new SQLiteCommand(sql, controller.Connection))
            {
                if (filterType != null)
                    cmd.Parameters.AddWithValue("@filter", $"%{filterType}%");

                using (var adapter = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    comboBoxOrder.DisplayMember = "Text";
                    comboBoxOrder.ValueMember = "Value";
                    comboBoxOrder.DataSource = dt;
                }
            }

            if (comboBoxOrder.Items.Count == 0)
                comboBoxOrder.Text = "(нет подходящих приказов)";
        }

        // Кнопка отмена
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Кнопка сохранить
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Выберите новый статус!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedOrderId <= 0)
            {
                MessageBox.Show("Выберите или создайте приказ-основание!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = comboBoxStatus.SelectedItem.ToString();
            DateTime date = dateTimePickerChange.Value;

            try
            {
                // 1. Записываем движение студента с СУЩЕСТВУЮЩИМ приказом
                controller.ExecuteNonQuery(
                    @"INSERT INTO Student_movement (Student_ID, Order_ID, Order_Action, Order_Effective_Date)
                  VALUES (@sid, @oid, @action, @date)",
                    ("@sid", studentId),
                    ("@oid", selectedOrderId),
                    ("@action", newStatus),
                    ("@date", date.ToString("yyyy-MM-dd")));

                // 2. Обновляем текущий статус студента
                controller.ExecuteNonQuery(
                    "UPDATE Student SET Nazv_statusa = @status WHERE Nom_stud = @id",
                    ("@status", newStatus),
                    ("@id", studentId));

                MessageBox.Show($"Статус успешно изменён на «{newStatus}»!\nПриказ №{selectedOrderId} применён.",
                                "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Запрет комбобоксам
        private void comboBoxStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBoxOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Кнопка новый приказ
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            using (FormOrders formOrders = new FormOrders())
            {
                if (formOrders.ShowDialog() == DialogResult.OK)
                {
                    LoadOrdersComboBox(); // обновляем список

                    // Автоматически выбираем только что созданный приказ
                    var lastOrder = controller.Total("SELECT MAX(Order_ID) AS LastID FROM Orders");
                    if (lastOrder.Rows.Count > 0 && lastOrder.Rows[0]["LastID"] != DBNull.Value)
                    {
                        long newId = Convert.ToInt64(lastOrder.Rows[0]["LastID"]);
                        comboBoxOrder.SelectedValue = newId; // ← вот так просто!
                        selectedOrderId = newId;
                    }
                }
            }
        }

        // Приказы выпадающий список
        private void comboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrder.SelectedValue != null && long.TryParse(comboBoxOrder.SelectedValue.ToString(), out long id))
            {
                selectedOrderId = id;
            }
            else
            {
                selectedOrderId = -1;
            }
        }
    }
}
