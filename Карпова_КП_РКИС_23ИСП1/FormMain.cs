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
            FillTableStudents();
            FillTableGraduates();
            FillTableApplicants();
            FillTableMovement();
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

        // Метод заполенния таблицы выпускники
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

                // 
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
    }
}
