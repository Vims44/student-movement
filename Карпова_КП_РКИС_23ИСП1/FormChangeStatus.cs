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
        private long studentId;
        Query controller;
        private long selectedOrderId = -1; // Выбранный ID приказа

        public FormChangeStatus(string nomStud)
        {
            InitializeComponent();
            this.studentId = long.Parse(nomStud);
            controller = new Query(AppSetting.ConnStr);

            LoadStudentInfo();
            LoadStatuses();
            LoadGroups();                   
            LoadOrdersComboBox();

            dateTimePickerChange.Value = DateTime.Today;

            // Скрываем выбор группы при старте
            comboBoxNewGroup.Visible = false;
            labelNewGroup.Visible = false;

            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
        }

        // Загрузка групп
        private void LoadGroups()
        {
            var groups = controller.GetComboBoxItems("Group", "Shifr_gr");
            comboBoxNewGroup.Items.Clear();
            foreach (string group in groups)
                comboBoxNewGroup.Items.Add(group);
        }
        // Загрузка информации о студентах
        private void LoadStudentInfo()
        {
            var dt = controller.GetStudentInfo(studentId);
            if (dt.Rows.Count == 0) return; // Студент не найден

            var row = dt.Rows[0];
            labelfio.Text = "ФИО студента: " + row["FIO"];
            lblBirthDate.Text = "Дата рождения: " + Convert.ToDateTime(row["Data_rojd"]).ToString("dd.MM.yyyy");
            lblGroup.Text = "Группа: " + row["Shifr_gr"];
            comboBoxStatus.Text = row["Nazv_statusa"].ToString();
        }

        // Загрузка статусов в комбобокс
        private void LoadStatuses()
        {
            comboBoxStatus.Items.Clear();
            var statuses = controller.GetAllStatuses();
            foreach (DataRow row in statuses.Rows)
                comboBoxStatus.Items.Add(row["Nazv_statusa"]);
        }

        // Загрузка приказов в ComboBox
        private void LoadOrdersComboBox(string filterType = null)
        {
            var dt = controller.GetOrdersForComboBox(filterType);
            comboBoxOrder.DisplayMember = "Text";
            comboBoxOrder.ValueMember = "Value";
            comboBoxOrder.DataSource = dt;
            if (dt.Rows.Count == 0)
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

            string newStatus = comboBoxStatus.SelectedItem.ToString();

            // Если перевод — проверяем группу
            if (newStatus == "Переведён")
            {
                if (comboBoxNewGroup.SelectedItem == null)
                {
                    MessageBox.Show("Выберите группу для перевода!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (selectedOrderId <= 0)
            {
                MessageBox.Show("Выберите или создайте приказ!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (newStatus == "Переведён")
                {
                    string newGroup = comboBoxNewGroup.SelectedItem.ToString();
                    controller.TranslateStudent(studentId, selectedOrderId, newGroup, dateTimePickerChange.Value);
                }
                else
                {
                    controller.ChangeStudentStatus(studentId, selectedOrderId, newStatus, dateTimePickerChange.Value);
                }

                MessageBox.Show($"Действие выполнено успешно!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void comboBoxNewGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Кнопка новый приказ
        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            using (var formOrders = new FormOrders())
            {
                if (formOrders.ShowDialog() == DialogResult.OK)
                {
                    LoadOrdersComboBox();
                    long newId = controller.GetLastOrderId();
                    if (newId > 0)
                    {
                        comboBoxOrder.SelectedValue = newId;
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

        // Комбобокс статус
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem?.ToString() == "Переведён")
            {
                labelNewGroup.Visible = true;
                comboBoxNewGroup.Visible = true;
                comboBoxNewGroup.DroppedDown = true;
                lblGroup.Visible = false;
            }
            else
            {
                labelNewGroup.Visible = false;
                comboBoxNewGroup.Visible = false;
            }
        }
    }
}
