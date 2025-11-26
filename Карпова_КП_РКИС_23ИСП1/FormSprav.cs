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
using System.IO;
using Карпова_КП_РКИС_23ИСП1.Controller;

namespace Карпова_КП_РКИС_23ИСП1
{
    public partial class FormSprav : Form
    {
        Query controller;
        DataTable groupTable;
        int mode = 0;

        public FormSprav()
        {
            InitializeComponent();
            controller = new Query(AppSetting.ConnStr); // Инициализация
        }

        // Метод загрузки формы справочники
        private void FormSprav_Load(object sender, EventArgs e)
        {
            // Запрос группы
            string groupTotal = @"SELECT [Group].Shifr_gr AS 'Группа',
                                         [Group].Shifr_spec AS 'Специальность',
                                         [Group].God_post AS 'Год_поступления',
                                         [Group].God_okon AS 'Год_окончания',
                                         Teacher.FIO AS 'Классный_руководитель',
                                         [Group].[Kol-vo_stud] AS 'Кол-во_студентов'
                                         FROM [Group]
                                         JOIN Teacher ON [Group].Tab_nom = Teacher.Tab_nom
                                         ORDER BY [Group].Shifr_gr";
            groupTable = controller.Total(groupTotal);
            dataGridViewGroup.DataSource = groupTable;
            toolStripGroupLabel1.Text = "Количество записей: " + (dataGridViewGroup.Rows.Count - 1);

            // Запрос статус
            string statusTotal = @"SELECT Nazv_statusa AS 'Статус'
                                            FROM Status
                                            ORDER BY Nazv_statusa";
            dataGridViewStatus.DataSource = controller.Total(statusTotal);
            toolStripStatusLabel2.Text = "Количество записей: " + (dataGridViewStatus.Rows.Count - 1);
        }

        // Поиск по первым буквам фамилии в статусе
        private void textBoxSearch_TextChanged_1(object sender, EventArgs e)
        {
            ApplyGroupFilters();
        }
        private void textBoxSearchTeacher_TextChanged(object sender, EventArgs e)
        {
            ApplyGroupFilters();
        }
        private void textBoxSearchYear_TextChanged(object sender, EventArgs e)
        {
            ApplyGroupFilters();
        }

        // Метод, собирающий фильтры вместе
        private void ApplyGroupFilters()
        {
            if (groupTable == null) return;
            StringBuilder filter = new StringBuilder();
            // Поиск по группе
            if (!string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                filter.Append($"Группа LIKE '{textBoxSearch.Text.Trim()}%'");
            }

            // Поиск по классному руководителю
            if (!string.IsNullOrWhiteSpace(textBoxSearchTeacher.Text))
            {
                if (filter.Length > 0) filter.Append(" AND ");
                filter.Append($"Классный_руководитель LIKE '%{textBoxSearchTeacher.Text.Trim()}%'");
            }

            // Поиск по году поступления
            if (!string.IsNullOrWhiteSpace(textBoxSearchYear.Text.Trim()))
            {
                string year = textBoxSearchYear.Text.Trim();
                // Проверка на число
                if (int.TryParse(year, out int y) && year.Length == 4)
                {
                    if (filter.Length > 0) filter.Append(" AND ");
                    filter.Append($"Год_поступления = {y}");
                }
                else if (!string.IsNullOrEmpty(year))
                {
                }
            }
            try
            {
                groupTable.DefaultView.RowFilter = filter.ToString();
            }
            catch (Exception)
            {
                // Если фильтр сломался — сброс
                groupTable.DefaultView.RowFilter = "";
            }
            // Обновление счётчика
            toolStripGroupLabel1.Text = "Количество записей: " + (dataGridViewGroup.Rows.Count - 1);
        }

        // Функция обновления таблицы статусов
        private void RefreshStatusTable()
        {
            string statusTotal = @"SELECT Nazv_statusa AS 'Статус'
                           FROM Status
                           ORDER BY Nazv_statusa";

            dataGridViewStatus.DataSource = controller.Total(statusTotal);
            toolStripStatusLabel2.Text = "Количество записей: " + (dataGridViewStatus.Rows.Count - 1);
        }

        // Добавление в правке
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddEdit form = new FormAddEdit();
            form.Text = "Добавление статуса";
            form.textBoxAddEdit.Clear(); // Очистка поля
            if (form.ShowDialog() == DialogResult.OK)
            {
                string newStatus = form.textBoxAddEdit.Text.Trim();
                if (string.IsNullOrEmpty(newStatus))
                {
                    MessageBox.Show("Введите название статуса!");
                    return;
                }
                try
                {
                    controller.ModifyStatus(0, newStatus); // Добавление
                    RefreshStatusTable();
                    MessageBox.Show("Статус успешно добавлен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Редактирование в правке
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите статус для редактирования!");
                return;
            }
            string oldValue = dataGridViewStatus.SelectedRows[0].Cells["Статус"].Value.ToString();
            FormAddEdit form = new FormAddEdit();
            form.Text = "Редактирование статуса";
            form.textBoxAddEdit.Text = oldValue;           
            if (form.ShowDialog() == DialogResult.OK)
            {
                string newValue = form.textBoxAddEdit.Text.Trim();
                if (string.IsNullOrEmpty(newValue))
                {
                    MessageBox.Show("Название не может быть пустым!");
                    return;
                }
                if (newValue == oldValue)
                {
                    MessageBox.Show("Название не изменено.");
                    return;
                }
                try
                {
                    controller.ModifyStatus(1, newValue, oldValue);
                    RefreshStatusTable();
                    MessageBox.Show("Статус успешно обновлён!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка редактирования", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Удаление в правке
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatus.SelectedRows.Count == 0)
                return;
            string value = dataGridViewStatus.SelectedRows[0].Cells["Статус"].Value.ToString();

            if (MessageBox.Show($"Вы действительно хотите удалить статус «{value}»?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    controller.DeleteStatus(value);   
                    RefreshStatusTable();
                    MessageBox.Show("Статус успешно удалён.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
                {
                    MessageBox.Show(
                        "Нельзя удалить этот статус, потому что он используется в других таблицах.",
                        "Ошибка удаления",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Кнопка очистки поиска
        private void buttonClearing_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            textBoxSearchTeacher.Clear();
            textBoxSearchYear.Clear();
            ApplyGroupFilters();
        }

        // Разрешение для года
        private void textBoxSearchYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        // Разрешение для кл рук
        private void textBoxSearchTeacher_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
