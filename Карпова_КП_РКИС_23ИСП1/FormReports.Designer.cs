
namespace Карпова_КП_РКИС_23ИСП1
{
    partial class FormReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tabMovement = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewMoventRep = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chartMovementReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadMovement = new System.Windows.Forms.Button();
            this.cmbYears = new System.Windows.Forms.ComboBox();
            this.dgvGroupReport = new System.Windows.Forms.DataGridView();
            this.chartGroupReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvOrdersReport = new System.Windows.Forms.DataGridView();
            this.chartOrdersReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvStudentsSpeciality = new System.Windows.Forms.DataGridView();
            this.chartStudentsSpeciality = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlReports.SuspendLayout();
            this.tabMovement.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoventRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovementReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGroupReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrdersReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSpeciality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudentsSpeciality)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.tabMovement);
            this.tabControlReports.Controls.Add(this.tabPage2);
            this.tabControlReports.Controls.Add(this.tabPage3);
            this.tabControlReports.Controls.Add(this.tabPage4);
            this.tabControlReports.Location = new System.Drawing.Point(12, 12);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(1524, 762);
            this.tabControlReports.TabIndex = 0;
            this.tabControlReports.SelectedIndexChanged += new System.EventHandler(this.tabControlReports_SelectedIndexChanged);
            // 
            // tabMovement
            // 
            this.tabMovement.Controls.Add(this.cmbYears);
            this.tabMovement.Controls.Add(this.btnLoadMovement);
            this.tabMovement.Controls.Add(this.chartMovementReport);
            this.tabMovement.Controls.Add(this.label1);
            this.tabMovement.Controls.Add(this.dataGridViewMoventRep);
            this.tabMovement.Location = new System.Drawing.Point(4, 29);
            this.tabMovement.Name = "tabMovement";
            this.tabMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovement.Size = new System.Drawing.Size(1516, 729);
            this.tabMovement.TabIndex = 0;
            this.tabMovement.Text = "Движение контингента по действиям";
            this.tabMovement.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartGroupReport);
            this.tabPage2.Controls.Add(this.dgvGroupReport);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1516, 729);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Численность студентов по группам";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartOrdersReport);
            this.tabPage3.Controls.Add(this.dgvOrdersReport);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1516, 729);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Количество приказов по типам";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chartStudentsSpeciality);
            this.tabPage4.Controls.Add(this.dgvStudentsSpeciality);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1516, 729);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Студенты по специальностям";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMoventRep
            // 
            this.dataGridViewMoventRep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMoventRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoventRep.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewMoventRep.Name = "dataGridViewMoventRep";
            this.dataGridViewMoventRep.ReadOnly = true;
            this.dataGridViewMoventRep.RowHeadersWidth = 51;
            this.dataGridViewMoventRep.RowTemplate.Height = 24;
            this.dataGridViewMoventRep.Size = new System.Drawing.Size(802, 515);
            this.dataGridViewMoventRep.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Год:";
            // 
            // chartMovementReport
            // 
            chartArea6.Name = "ChartArea1";
            this.chartMovementReport.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartMovementReport.Legends.Add(legend6);
            this.chartMovementReport.Location = new System.Drawing.Point(823, 6);
            this.chartMovementReport.Name = "chartMovementReport";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartMovementReport.Series.Add(series6);
            this.chartMovementReport.Size = new System.Drawing.Size(687, 515);
            this.chartMovementReport.TabIndex = 3;
            this.chartMovementReport.Text = "chart1";
            // 
            // btnLoadMovement
            // 
            this.btnLoadMovement.Location = new System.Drawing.Point(1264, 527);
            this.btnLoadMovement.Name = "btnLoadMovement";
            this.btnLoadMovement.Size = new System.Drawing.Size(164, 43);
            this.btnLoadMovement.TabIndex = 4;
            this.btnLoadMovement.Text = "Показать";
            this.btnLoadMovement.UseVisualStyleBackColor = true;
            this.btnLoadMovement.Click += new System.EventHandler(this.btnLoadMovement_Click);
            // 
            // cmbYears
            // 
            this.cmbYears.FormattingEnabled = true;
            this.cmbYears.Location = new System.Drawing.Point(59, 552);
            this.cmbYears.Name = "cmbYears";
            this.cmbYears.Size = new System.Drawing.Size(121, 28);
            this.cmbYears.TabIndex = 5;
            // 
            // dgvGroupReport
            // 
            this.dgvGroupReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGroupReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupReport.Location = new System.Drawing.Point(7, 7);
            this.dgvGroupReport.Name = "dgvGroupReport";
            this.dgvGroupReport.ReadOnly = true;
            this.dgvGroupReport.RowHeadersWidth = 51;
            this.dgvGroupReport.RowTemplate.Height = 24;
            this.dgvGroupReport.Size = new System.Drawing.Size(750, 716);
            this.dgvGroupReport.TabIndex = 0;
            // 
            // chartGroupReport
            // 
            chartArea5.Name = "ChartArea1";
            this.chartGroupReport.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartGroupReport.Legends.Add(legend5);
            this.chartGroupReport.Location = new System.Drawing.Point(764, 7);
            this.chartGroupReport.Name = "chartGroupReport";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartGroupReport.Series.Add(series5);
            this.chartGroupReport.Size = new System.Drawing.Size(746, 716);
            this.chartGroupReport.TabIndex = 1;
            this.chartGroupReport.Text = "chart1";
            // 
            // dgvOrdersReport
            // 
            this.dgvOrdersReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdersReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersReport.Location = new System.Drawing.Point(7, 7);
            this.dgvOrdersReport.Name = "dgvOrdersReport";
            this.dgvOrdersReport.ReadOnly = true;
            this.dgvOrdersReport.RowHeadersWidth = 51;
            this.dgvOrdersReport.RowTemplate.Height = 24;
            this.dgvOrdersReport.Size = new System.Drawing.Size(757, 722);
            this.dgvOrdersReport.TabIndex = 0;
            // 
            // chartOrdersReport
            // 
            chartArea7.Name = "ChartArea1";
            this.chartOrdersReport.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartOrdersReport.Legends.Add(legend7);
            this.chartOrdersReport.Location = new System.Drawing.Point(781, 7);
            this.chartOrdersReport.Name = "chartOrdersReport";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chartOrdersReport.Series.Add(series7);
            this.chartOrdersReport.Size = new System.Drawing.Size(710, 708);
            this.chartOrdersReport.TabIndex = 1;
            this.chartOrdersReport.Text = "chart1";
            // 
            // dgvStudentsSpeciality
            // 
            this.dgvStudentsSpeciality.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudentsSpeciality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsSpeciality.Location = new System.Drawing.Point(7, 18);
            this.dgvStudentsSpeciality.Name = "dgvStudentsSpeciality";
            this.dgvStudentsSpeciality.ReadOnly = true;
            this.dgvStudentsSpeciality.RowHeadersWidth = 51;
            this.dgvStudentsSpeciality.RowTemplate.Height = 24;
            this.dgvStudentsSpeciality.Size = new System.Drawing.Size(793, 708);
            this.dgvStudentsSpeciality.TabIndex = 0;
            // 
            // chartStudentsSpeciality
            // 
            chartArea8.Name = "ChartArea1";
            this.chartStudentsSpeciality.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartStudentsSpeciality.Legends.Add(legend8);
            this.chartStudentsSpeciality.Location = new System.Drawing.Point(806, 18);
            this.chartStudentsSpeciality.Name = "chartStudentsSpeciality";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.chartStudentsSpeciality.Series.Add(series8);
            this.chartStudentsSpeciality.Size = new System.Drawing.Size(704, 705);
            this.chartStudentsSpeciality.TabIndex = 1;
            this.chartStudentsSpeciality.Text = "chart1";
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 786);
            this.Controls.Add(this.tabControlReports);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormReports";
            this.Text = "Отчёты";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.tabControlReports.ResumeLayout(false);
            this.tabMovement.ResumeLayout(false);
            this.tabMovement.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoventRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovementReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGroupReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrdersReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsSpeciality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudentsSpeciality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReports;
        private System.Windows.Forms.TabPage tabMovement;
        private System.Windows.Forms.Button btnLoadMovement;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMovementReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMoventRep;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbYears;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGroupReport;
        private System.Windows.Forms.DataGridView dgvGroupReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrdersReport;
        private System.Windows.Forms.DataGridView dgvOrdersReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStudentsSpeciality;
        private System.Windows.Forms.DataGridView dgvStudentsSpeciality;
    }
}