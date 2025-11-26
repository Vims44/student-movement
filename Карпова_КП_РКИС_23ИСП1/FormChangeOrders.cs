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
    public partial class FormChangeOrders : Form
    {
        private Query controller;
        private long orderId = -1;

        public FormChangeOrders(long editOrderId = -1)
        {
            InitializeComponent();
            controller = new Query(AppSetting.ConnStr);
            this.orderId = editOrderId;

            if (orderId > 0)
            {
                this.Text = "Редактирование приказа";
                LoadOrderData();
            }
            else
            {
                this.Text = "Добавление приказа";
                dateTimePicker1.Value = DateTime.Today;
            }
        }

        private void LoadOrderData()
        {
            DataTable dt = controller.Total($"SELECT * FROM Orders WHERE Order_ID = {orderId}");
            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];
                textBoxTypeOrders.Text = r["Order_Type"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(r["Order_Date"]);
                textBoxComm.Text = r["Comment"]?.ToString() ?? "";
            }
        }

        // Кнопка сохранить
        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTypeOrders.Text))
            {
                MessageBox.Show("Введите тип приказа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (orderId == -1)
                {
                    // Добавление
                    controller.AddOrder(
                        textBoxTypeOrders.Text.Trim(),
                        dateTimePicker1.Value,
                        textBoxComm.Text.Trim()
                    );
                    MessageBox.Show("Приказ успешно добавлен!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Редактирование
                    controller.UpdateOrder(
                        orderId,
                        textBoxTypeOrders.Text.Trim(),
                        dateTimePicker1.Value,
                        textBoxComm.Text.Trim()
                    );
                    MessageBox.Show("Приказ успешно обновлён!", "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Кнопка отменить
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
