using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Карпова_КП_РКИС_23ИСП1
{
    public partial class FormAddEdit : Form
    {
        public bool isEdit;

        public FormAddEdit()
        {
            InitializeComponent();
        }

        // Кнопка подтверждения
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddEdit.Text))
            {
                MessageBox.Show("Введите корректный статус!");
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Кнопка отмены
        private void buttonCancellation_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
