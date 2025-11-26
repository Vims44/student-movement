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
        }

        // Загрузка формы
        private void FormOrders_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            FillTableOrders();
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

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOrders.CurrentRow == null)
            {
                dataGridViewStud.DataSource = null;
                dataGridViewOrderStud.DataSource = null;
                return;
            }
            long id = Convert.ToInt64(dataGridViewOrders.CurrentRow.Cells["Идентификатор приказа"].Value);
            FillTableStudents(id);
            // Очистить таблицу приказов студента при смене приказа
            dataGridViewOrderStud.DataSource = null;
        }

        // Метод заполнения таблицы студентов по приказу
        private void FillTableStudents(long orderId)
        {
            DataTable dt = controller.GetStudentsByOrder(orderId);
            dataGridViewStud.DataSource = dt;
            toolStripOrders.Text = $"Количество студентов: {dt.Rows.Count}";
        }


        private void dataGridViewStud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewStud.CurrentRow == null)
            {
                dataGridViewOrderStud.DataSource = null;
                return;
            }
            long studentId = Convert.ToInt64(dataGridViewStud.CurrentRow.Cells["Номер"].Value);
            FillTableStudentOrders(studentId);
        }

        // Метод заполнения таблицы приказов по студенту
        private void FillTableStudentOrders(long studentId)
        {
            DataTable dt = controller.GetOrdersByStudent(studentId);
            dataGridViewOrderStud.DataSource = dt;
            toolStripOrders.Text = $"Количество приказов: {dt.Rows.Count}";
        }
    }
}
