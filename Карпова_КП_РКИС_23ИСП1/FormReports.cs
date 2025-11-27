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
    public partial class FormReports : Form
    {
        Query controller;

        public FormReports()
        {
            InitializeComponent();
            controller = new Query(AppSetting.ConnStr);
        }

        // Кнопка показать отчёт Движение контингента по действиям
        private void btnLoadMovement_Click(object sender, EventArgs e)
        {
            if (cmbYears.SelectedItem == null)
            {
                MessageBox.Show("Выберите год!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedYear = cmbYears.SelectedItem.ToString();

            // 1. Получаем данные из базы
            DataTable dt = controller.Total(@"
        SELECT 
            Order_Action AS 'Действие',
            COUNT(*) AS 'Количество',
            MIN(Order_Effective_Date) AS 'Мин. дата',
            MAX(Order_Effective_Date) AS 'Макс. дата'
        FROM Student_movement
        WHERE strftime('%Y', Order_Effective_Date) = '" + selectedYear + @"'
        GROUP BY Order_Action
        ORDER BY COUNT(*) DESC;
    ");

            // 2. Заполняем DataGridView
            dataGridViewMoventRep.DataSource = dt;

            // 3. Настраиваем диаграмму
            chartMovementReport.Series.Clear();
            var series = chartMovementReport.Series.Add("Количество");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series.XValueMember = "Действие";
            series.YValueMembers = "Количество";
            chartMovementReport.DataSource = dt;
            chartMovementReport.DataBind();
        }

        // Форма загрузки
        private void FormReports_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // Заполняем ComboBox годов на основе данных Student_movement
            DataTable dtYears = controller.Total(@"SELECT DISTINCT strftime('%Y', Order_Effective_Date) AS Year 
                                           FROM Student_movement 
                                           ORDER BY Year DESC");
            cmbYears.Items.Clear();
            foreach (DataRow r in dtYears.Rows)
                cmbYears.Items.Add(r["Year"].ToString());

            if (cmbYears.Items.Count > 0)
                cmbYears.SelectedIndex = 0; // по умолчанию первый год
        }

        // Панель вкладок
        private void tabControlReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Вкладка — Численность студентов по группам
            if (tabControlReports.SelectedTab == tabPage2)
            {
                LoadGroupReport();
            }
            // Вкладка - Количество приказов по типу
            if (tabControlReports.SelectedTab == tabPage2)
            {
                LoadOrdersReport();
            }
            // Вкладка - Студенты по специальности
            if (tabControlReports.SelectedTab == tabPage3)
            {
                LoadStudentsBySpecialityReport();
            }
        }

        // Загрузка Численность студентов по группам
        private void LoadGroupReport()
        {
            try
            {
                // Получаем данные: группы и количество студентов
                string sql = @"SELECT 
                        s.Shifr_gr AS 'Группа',
                        COUNT(*) AS 'Количество студентов'
                       FROM Student s
                       GROUP BY s.Shifr_gr
                       ORDER BY s.Shifr_gr";

                DataTable dt = controller.Total(sql);
                dgvGroupReport.DataSource = dt;

                // Настройка диаграммы
                chartGroupReport.Series.Clear();
                chartGroupReport.ChartAreas[0].AxisX.Title = "";
                chartGroupReport.ChartAreas[0].AxisY.Title = "";

                var series = chartGroupReport.Series.Add("Студенты");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                foreach (DataRow row in dt.Rows)
                {
                    string group = row["Группа"].ToString();
                    int count = Convert.ToInt32(row["Количество студентов"]);
                    series.Points.AddXY(group, count);
                }

                // Настройка подписей на пироге
                series.IsValueShownAsLabel = true;
                series.Label = "#PERCENT{P1}"; // Показывает процент
                series.LegendText = "#VALX";   // Легенда — название группы
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке отчёта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Загрузка Количество приказов по типу
        private void LoadOrdersReport()
        {
            try
            {
                // Получаем количество приказов по типам
                string sql = @"SELECT 
                        Order_Type AS 'Тип приказа',
                        COUNT(*) AS 'Количество приказов'
                       FROM Orders
                       GROUP BY Order_Type
                       ORDER BY Order_Type";

                DataTable dt = controller.Total(sql);
                dgvOrdersReport.DataSource = dt;

                // Настройка диаграммы
                chartOrdersReport.Series.Clear();
                chartOrdersReport.ChartAreas[0].AxisX.Title = "";
                chartOrdersReport.ChartAreas[0].AxisY.Title = "";

                var series = chartOrdersReport.Series.Add("Приказы");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                foreach (DataRow row in dt.Rows)
                {
                    string type = row["Тип приказа"].ToString();
                    int count = Convert.ToInt32(row["Количество приказов"]);
                    series.Points.AddXY(type, count);
                }

                // Подписи на пироге
                series.IsValueShownAsLabel = true;
                series.Label = "#PERCENT{P1}"; // Процент
                series.LegendText = "#VALX";   // Легенда — тип приказа
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке отчёта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Загрузка Студенты по специальности
        private void LoadStudentsBySpecialityReport()
        {
            try
            {
                // Получаем количество студентов по специальностям
                string sql = @"
            SELECT sp.Nazvanie AS 'Специальность',
                   COUNT(s.Nom_stud) AS 'Количество студентов'
            FROM Student s
            LEFT JOIN ""Group"" g ON s.Shifr_gr = g.Shifr_gr
            LEFT JOIN Speciality sp ON g.Shifr_spec = sp.Shifr_spec
            GROUP BY sp.Nazvanie
            ORDER BY sp.Nazvanie";

                DataTable dt = controller.Total(sql);
                dgvStudentsSpeciality.DataSource = dt;

                // Настройка диаграммы
                chartStudentsSpeciality.Series.Clear();
                chartStudentsSpeciality.ChartAreas[0].AxisX.Title = "";
                chartStudentsSpeciality.ChartAreas[0].AxisY.Title = "";

                var series = chartStudentsSpeciality.Series.Add("Студенты");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

                foreach (DataRow row in dt.Rows)
                {
                    string speciality = row["Специальность"].ToString();
                    int count = Convert.ToInt32(row["Количество студентов"]);
                    series.Points.AddXY(speciality, count);
                }

                // Подписи на пироге
                series.IsValueShownAsLabel = true;
                series.Label = "#PERCENT{P1}"; // Процент
                series.LegendText = "#VALX";   // Легенда — название специальности
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке отчёта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
