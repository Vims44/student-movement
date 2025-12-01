using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Карпова_КП_РКИС_23ИСП1.Controller;

namespace Карпова_КП_РКИС_23ИСП1
{
    public partial class FormOrders : Form
    {
        Query controller;
        int mode = 0;

        public FormOrders()
        {
            InitializeComponent();
            controller = new Query(AppSetting.ConnStr); // Инициализация
            FillTableOrders();

            // Подписываемся на событие выбора строки
            this.dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
            // Опционально: чтобы при старте ничего не было выбрано
            this.dataGridViewOrders.ClearSelection();
        }

        // Загрузка формы
        private void FormOrders_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FillTableOrders();
            label2.Text = "Выберите приказ";
            toolStripOrders.Text = "Количество студентов в приказе: 0";
        }

        // Метод заполнения таблицы приказы
        private void FillTableOrders(string query = "")
        {
            DataTable dt = controller.Orders(query);
            dataGridViewOrders.DataSource = dt;
            toolStripLabelOrders.Text = $"Количество записей: {dt.Rows.Count}";
        }

        // Добавить приказ
        private void добавитьПриказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new FormChangeOrders())
            {
                if (form.ShowDialog() == DialogResult.OK)
                    FillTableOrders();
            }
        }

        // Редактировать приказ
        private void редактироватьПриказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null)
            {
                MessageBox.Show("Выберите приказ для редактирования!");
                return;
            }

            long id = Convert.ToInt64(dataGridViewOrders.CurrentRow.Cells["Идентификатор приказа"].Value);

            using (var form = new FormChangeOrders(id))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    FillTableOrders();
            }
        }

        // Удалить приказ 
        private void удалитьПриказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null)
            {
                MessageBox.Show("Выберите приказ для удаления!");
                return;
            }

            long id = Convert.ToInt64(dataGridViewOrders.CurrentRow.Cells["Идентификатор приказа"].Value);
            string type = dataGridViewOrders.CurrentRow.Cells["Тип приказа"].Value.ToString();

            if (MessageBox.Show($"Удалить приказ «{type}»?\n\nВнимание: удаление невозможно, если приказ уже применён к студентам.",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    controller.DeleteOrder(id);
                    MessageBox.Show("Приказ удалён!");
                    FillTableOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Невозможно удалить", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Таблица приказов
        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null)
            {
                dataGridViewStud.DataSource = null;
                return;
            }
            long id = Convert.ToInt64(dataGridViewOrders.CurrentRow.Cells["Идентификатор приказа"].Value);
            FillTableStudents(id);
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            // Если есть выбранная строка
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                // Берём первую (и единственную) выделенную строку
                DataGridViewRow row = dataGridViewOrders.SelectedRows[0];

                // Проверяем, что ячейка с ID не null (на всякий случай)
                if (row.Cells["Идентификатор приказа"].Value != null &&
                    long.TryParse(row.Cells["Идентификатор приказа"].Value.ToString(), out long orderId))
                {
                    FillTableStudents(orderId);
                }
                else
                {
                    dataGridViewStud.DataSource = null;
                    toolStripOrders.Text = "Количество студентов в приказе: 0";
                }
            }
            else
            {
                // Если ничего не выбрано
                dataGridViewStud.DataSource = null;
                toolStripOrders.Text = "Количество студентов в приказе: 0";
                label2.Text = "Выберите приказ";
            }
        }

        // Метод заполнения таблицы студентов по выбранному приказу
        private void FillTableStudents(long orderId)
        {
            DataTable dt = controller.GetStudentsByOrder(orderId);
            dataGridViewStud.DataSource = dt;
            toolStripOrders.Text = $"Количество студентов в приказе: {dt.Rows.Count}";

            // Проверяем, есть ли текущая строка в верхней таблице
            if (dataGridViewOrders.CurrentRow != null)
            {
                var row = dataGridViewOrders.CurrentRow;
                string type = row.Cells["Тип приказа"].Value?.ToString() ?? "Приказ";
                string dateStr = row.Cells["Дата приказа"].Value?.ToString() ?? "";
                string comment = row.Cells["Комментарий"].Value?.ToString() ?? "";

                DateTime date = DateTime.Parse(dateStr);
                string number = "б/н";
                var match = System.Text.RegularExpressions.Regex.Match(comment, @"№\s*([0-9]+-[ВЗОA]+)");
                if (match.Success)
                    number = match.Groups[1].Value;
                label2.Text = $"Студенты по приказу «{type} № {number} от {date:dd.MM.yyyy}»";
            }
            else
            {
                label2.Text = "Выберите приказ";
            }
        }
    }
}
