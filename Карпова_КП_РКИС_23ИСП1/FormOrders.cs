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


        private void FormOrders_Load(object sender, EventArgs e)
        {
            // Здесь можно инициализировать данные формы
            // Например, заполнение таблицы приказов
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
    }
}
