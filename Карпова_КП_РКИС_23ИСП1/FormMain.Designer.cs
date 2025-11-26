
namespace Карпова_КП_РКИС_23ИСП1
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.группаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxStudFIO = new System.Windows.Forms.TextBox();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxCours = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.comboBoxSpec = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonStatusChange = new System.Windows.Forms.Button();
            this.toolStripStudent = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelStudent = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabPageStudentMovement = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelMovement = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewMovement = new System.Windows.Forms.DataGridView();
            this.tabPageGraduates = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelGraduate = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewGraduates = new System.Windows.Forms.DataGridView();
            this.tabPageApplicants = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelApplicants = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewApplicants = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStripStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabPageStudentMovement.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovement)).BeginInit();
            this.tabPageGraduates.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraduates)).BeginInit();
            this.tabPageApplicants.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicants)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.отчётыToolStripMenuItem,
            this.приказыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1556, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.группаToolStripMenuItem,
            this.статусToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // группаToolStripMenuItem
            // 
            this.группаToolStripMenuItem.Name = "группаToolStripMenuItem";
            this.группаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.группаToolStripMenuItem.Text = "Группа";
            this.группаToolStripMenuItem.Click += new System.EventHandler(this.группаToolStripMenuItem_Click);
            // 
            // статусToolStripMenuItem
            // 
            this.статусToolStripMenuItem.Name = "статусToolStripMenuItem";
            this.статусToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.статусToolStripMenuItem.Text = "Статус";
            this.статусToolStripMenuItem.Click += new System.EventHandler(this.статусToolStripMenuItem_Click);
            // 
            // отчётыToolStripMenuItem
            // 
            this.отчётыToolStripMenuItem.Name = "отчётыToolStripMenuItem";
            this.отчётыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.отчётыToolStripMenuItem.Text = "Отчёты";
            // 
            // приказыToolStripMenuItem
            // 
            this.приказыToolStripMenuItem.Name = "приказыToolStripMenuItem";
            this.приказыToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.приказыToolStripMenuItem.Text = "Приказы";
            this.приказыToolStripMenuItem.Click += new System.EventHandler(this.приказыToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStudents);
            this.tabControlMain.Controls.Add(this.tabPageStudentMovement);
            this.tabControlMain.Controls.Add(this.tabPageGraduates);
            this.tabControlMain.Controls.Add(this.tabPageApplicants);
            this.tabControlMain.Location = new System.Drawing.Point(12, 40);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1532, 729);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.groupBox1);
            this.tabPageStudents.Controls.Add(this.buttonStatusChange);
            this.tabPageStudents.Controls.Add(this.toolStripStudent);
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 29);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(1524, 696);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Студенты";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxStudFIO);
            this.groupBox1.Controls.Add(this.buttonClearSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.comboBoxCours);
            this.groupBox1.Controls.Add(this.comboBoxGroup);
            this.groupBox1.Controls.Add(this.comboBoxPayment);
            this.groupBox1.Controls.Add(this.comboBoxSpec);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1167, 157);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отобрать по:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(848, 66);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(144, 49);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxStudFIO
            // 
            this.textBoxStudFIO.Location = new System.Drawing.Point(232, 21);
            this.textBoxStudFIO.Name = "textBoxStudFIO";
            this.textBoxStudFIO.Size = new System.Drawing.Size(199, 26);
            this.textBoxStudFIO.TabIndex = 5;
            this.textBoxStudFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStudFIO_KeyPress);
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.Location = new System.Drawing.Point(1016, 66);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(142, 49);
            this.buttonClearSearch.TabIndex = 23;
            this.buttonClearSearch.Text = "Очистить поиск";
            this.buttonClearSearch.UseVisualStyleBackColor = true;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО студента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статус:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(232, 121);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 26);
            this.textBoxAge.TabIndex = 21;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Группа:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Специальность:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Возраст:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(625, 53);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(199, 28);
            this.comboBoxStatus.TabIndex = 12;
            this.comboBoxStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxStatus_KeyPress);
            // 
            // comboBoxCours
            // 
            this.comboBoxCours.FormattingEnabled = true;
            this.comboBoxCours.Location = new System.Drawing.Point(625, 19);
            this.comboBoxCours.Name = "comboBoxCours";
            this.comboBoxCours.Size = new System.Drawing.Size(199, 28);
            this.comboBoxCours.TabIndex = 18;
            this.comboBoxCours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxCours_KeyPress);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(232, 53);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(199, 28);
            this.comboBoxGroup.TabIndex = 13;
            this.comboBoxGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxGroup_KeyPress);
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Location = new System.Drawing.Point(625, 86);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(199, 28);
            this.comboBoxPayment.TabIndex = 17;
            this.comboBoxPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxPayment_KeyPress);
            // 
            // comboBoxSpec
            // 
            this.comboBoxSpec.FormattingEnabled = true;
            this.comboBoxSpec.Location = new System.Drawing.Point(232, 87);
            this.comboBoxSpec.Name = "comboBoxSpec";
            this.comboBoxSpec.Size = new System.Drawing.Size(199, 28);
            this.comboBoxSpec.TabIndex = 14;
            this.comboBoxSpec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSpec_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(469, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Курс:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Форма оплаты:";
            // 
            // buttonStatusChange
            // 
            this.buttonStatusChange.Location = new System.Drawing.Point(1313, 514);
            this.buttonStatusChange.Name = "buttonStatusChange";
            this.buttonStatusChange.Size = new System.Drawing.Size(197, 52);
            this.buttonStatusChange.TabIndex = 2;
            this.buttonStatusChange.Text = "Изменить статус студента";
            this.buttonStatusChange.UseVisualStyleBackColor = true;
            this.buttonStatusChange.Click += new System.EventHandler(this.buttonStatusChange_Click);
            // 
            // toolStripStudent
            // 
            this.toolStripStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripStudent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelStudent});
            this.toolStripStudent.Location = new System.Drawing.Point(3, 668);
            this.toolStripStudent.Name = "toolStripStudent";
            this.toolStripStudent.Size = new System.Drawing.Size(1518, 25);
            this.toolStripStudent.TabIndex = 1;
            this.toolStripStudent.Text = "toolStrip1";
            // 
            // toolStripLabelStudent
            // 
            this.toolStripLabelStudent.Name = "toolStripLabelStudent";
            this.toolStripLabelStudent.Size = new System.Drawing.Size(154, 22);
            this.toolStripLabelStudent.Text = "toolStripLabelStudent";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(4, 7);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1514, 495);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // tabPageStudentMovement
            // 
            this.tabPageStudentMovement.Controls.Add(this.toolStrip3);
            this.tabPageStudentMovement.Controls.Add(this.dataGridViewMovement);
            this.tabPageStudentMovement.Location = new System.Drawing.Point(4, 29);
            this.tabPageStudentMovement.Name = "tabPageStudentMovement";
            this.tabPageStudentMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentMovement.Size = new System.Drawing.Size(1524, 696);
            this.tabPageStudentMovement.TabIndex = 1;
            this.tabPageStudentMovement.Text = "Движение студентов";
            this.tabPageStudentMovement.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelMovement});
            this.toolStrip3.Location = new System.Drawing.Point(3, 668);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1518, 25);
            this.toolStrip3.TabIndex = 1;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabelMovement
            // 
            this.toolStripLabelMovement.Name = "toolStripLabelMovement";
            this.toolStripLabelMovement.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabelMovement.Text = "toolStripLabel1";
            // 
            // dataGridViewMovement
            // 
            this.dataGridViewMovement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovement.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewMovement.Name = "dataGridViewMovement";
            this.dataGridViewMovement.ReadOnly = true;
            this.dataGridViewMovement.RowHeadersWidth = 51;
            this.dataGridViewMovement.RowTemplate.Height = 24;
            this.dataGridViewMovement.Size = new System.Drawing.Size(1465, 422);
            this.dataGridViewMovement.TabIndex = 0;
            // 
            // tabPageGraduates
            // 
            this.tabPageGraduates.Controls.Add(this.toolStrip1);
            this.tabPageGraduates.Controls.Add(this.dataGridViewGraduates);
            this.tabPageGraduates.Location = new System.Drawing.Point(4, 29);
            this.tabPageGraduates.Name = "tabPageGraduates";
            this.tabPageGraduates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraduates.Size = new System.Drawing.Size(1524, 696);
            this.tabPageGraduates.TabIndex = 2;
            this.tabPageGraduates.Text = "Выпускники";
            this.tabPageGraduates.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelGraduate});
            this.toolStrip1.Location = new System.Drawing.Point(3, 668);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1518, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelGraduate
            // 
            this.toolStripLabelGraduate.Name = "toolStripLabelGraduate";
            this.toolStripLabelGraduate.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabelGraduate.Text = "toolStripLabel1";
            // 
            // dataGridViewGraduates
            // 
            this.dataGridViewGraduates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGraduates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGraduates.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewGraduates.Name = "dataGridViewGraduates";
            this.dataGridViewGraduates.ReadOnly = true;
            this.dataGridViewGraduates.RowHeadersWidth = 51;
            this.dataGridViewGraduates.RowTemplate.Height = 24;
            this.dataGridViewGraduates.Size = new System.Drawing.Size(1511, 392);
            this.dataGridViewGraduates.TabIndex = 0;
            // 
            // tabPageApplicants
            // 
            this.tabPageApplicants.Controls.Add(this.toolStrip2);
            this.tabPageApplicants.Controls.Add(this.dataGridViewApplicants);
            this.tabPageApplicants.Location = new System.Drawing.Point(4, 29);
            this.tabPageApplicants.Name = "tabPageApplicants";
            this.tabPageApplicants.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApplicants.Size = new System.Drawing.Size(1524, 696);
            this.tabPageApplicants.TabIndex = 3;
            this.tabPageApplicants.Text = "Абитуриенты";
            this.tabPageApplicants.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelApplicants});
            this.toolStrip2.Location = new System.Drawing.Point(3, 668);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1518, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabelApplicants
            // 
            this.toolStripLabelApplicants.Name = "toolStripLabelApplicants";
            this.toolStripLabelApplicants.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabelApplicants.Text = "toolStripLabel1";
            // 
            // dataGridViewApplicants
            // 
            this.dataGridViewApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplicants.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewApplicants.Name = "dataGridViewApplicants";
            this.dataGridViewApplicants.ReadOnly = true;
            this.dataGridViewApplicants.RowHeadersWidth = 51;
            this.dataGridViewApplicants.RowTemplate.Height = 24;
            this.dataGridViewApplicants.Size = new System.Drawing.Size(1511, 369);
            this.dataGridViewApplicants.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 802);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.Text = "Движение студентов по статусам";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripStudent.ResumeLayout(false);
            this.toolStripStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabPageStudentMovement.ResumeLayout(false);
            this.tabPageStudentMovement.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovement)).EndInit();
            this.tabPageGraduates.ResumeLayout(false);
            this.tabPageGraduates.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGraduates)).EndInit();
            this.tabPageApplicants.ResumeLayout(false);
            this.tabPageApplicants.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplicants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem группаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приказыToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageStudentMovement;
        private System.Windows.Forms.TabPage tabPageGraduates;
        private System.Windows.Forms.TabPage tabPageApplicants;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.ToolStrip toolStripStudent;
        private System.Windows.Forms.ToolStripLabel toolStripLabelStudent;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridViewGraduates;
        private System.Windows.Forms.ToolStripLabel toolStripLabelGraduate;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelApplicants;
        private System.Windows.Forms.DataGridView dataGridViewApplicants;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMovement;
        private System.Windows.Forms.DataGridView dataGridViewMovement;
        private System.Windows.Forms.Button buttonStatusChange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStudFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSpec;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}

