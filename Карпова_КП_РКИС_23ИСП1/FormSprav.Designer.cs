
namespace Карпова_КП_РКИС_23ИСП1
{
    partial class FormSprav
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
            this.tabctrlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonClearing = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchYear = new System.Windows.Forms.TextBox();
            this.textBoxSearchTeacher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGroupLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewGroup = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewStatus = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabctrlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabctrlMain
            // 
            this.tabctrlMain.Controls.Add(this.tabPage1);
            this.tabctrlMain.Controls.Add(this.tabPage2);
            this.tabctrlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.tabctrlMain.Location = new System.Drawing.Point(12, 12);
            this.tabctrlMain.Name = "tabctrlMain";
            this.tabctrlMain.SelectedIndex = 0;
            this.tabctrlMain.Size = new System.Drawing.Size(1469, 641);
            this.tabctrlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonClearing);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxSearchYear);
            this.tabPage1.Controls.Add(this.textBoxSearchTeacher);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.textBoxSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dataGridViewGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1461, 608);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Группа";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonClearing
            // 
            this.buttonClearing.Location = new System.Drawing.Point(579, 472);
            this.buttonClearing.Name = "buttonClearing";
            this.buttonClearing.Size = new System.Drawing.Size(155, 60);
            this.buttonClearing.TabIndex = 11;
            this.buttonClearing.Text = "Очистить поиск";
            this.buttonClearing.UseVisualStyleBackColor = true;
            this.buttonClearing.Click += new System.EventHandler(this.buttonClearing_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Поиск по году поступления:";
            // 
            // textBoxSearchYear
            // 
            this.textBoxSearchYear.Location = new System.Drawing.Point(326, 525);
            this.textBoxSearchYear.Name = "textBoxSearchYear";
            this.textBoxSearchYear.Size = new System.Drawing.Size(210, 26);
            this.textBoxSearchYear.TabIndex = 9;
            this.textBoxSearchYear.TextChanged += new System.EventHandler(this.textBoxSearchYear_TextChanged);
            this.textBoxSearchYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchYear_KeyPress);
            // 
            // textBoxSearchTeacher
            // 
            this.textBoxSearchTeacher.Location = new System.Drawing.Point(326, 492);
            this.textBoxSearchTeacher.Name = "textBoxSearchTeacher";
            this.textBoxSearchTeacher.Size = new System.Drawing.Size(210, 26);
            this.textBoxSearchTeacher.TabIndex = 8;
            this.textBoxSearchTeacher.TextChanged += new System.EventHandler(this.textBoxSearchTeacher_TextChanged);
            this.textBoxSearchTeacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchTeacher_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск по классному руководителю:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGroupLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 580);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1455, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripGroupLabel1
            // 
            this.toolStripGroupLabel1.Name = "toolStripGroupLabel1";
            this.toolStripGroupLabel1.Size = new System.Drawing.Size(111, 22);
            this.toolStripGroupLabel1.Text = "toolStripLabel1";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(326, 453);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(210, 26);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Поиск по группе:";
            // 
            // dataGridViewGroup
            // 
            this.dataGridViewGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroup.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewGroup.Name = "dataGridViewGroup";
            this.dataGridViewGroup.ReadOnly = true;
            this.dataGridViewGroup.RowHeadersWidth = 51;
            this.dataGridViewGroup.RowTemplate.Height = 24;
            this.dataGridViewGroup.Size = new System.Drawing.Size(1275, 436);
            this.dataGridViewGroup.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Controls.Add(this.dataGridViewStatus);
            this.tabPage2.Controls.Add(this.menuStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1461, 608);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статус";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 580);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1455, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(111, 22);
            this.toolStripStatusLabel2.Text = "toolStripLabel2";
            // 
            // dataGridViewStatus
            // 
            this.dataGridViewStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatus.Location = new System.Drawing.Point(16, 41);
            this.dataGridViewStatus.Name = "dataGridViewStatus";
            this.dataGridViewStatus.ReadOnly = true;
            this.dataGridViewStatus.RowHeadersWidth = 51;
            this.dataGridViewStatus.RowTemplate.Height = 24;
            this.dataGridViewStatus.Size = new System.Drawing.Size(328, 247);
            this.dataGridViewStatus.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1455, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить статус";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.редактироватьToolStripMenuItem.Text = "Редактировать статус";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить статус";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // FormSprav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 712);
            this.Controls.Add(this.tabctrlMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormSprav";
            this.Text = "Справочники";
            this.Load += new System.EventHandler(this.FormSprav_Load);
            this.tabctrlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroup)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatus)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabctrlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewGroup;
        private System.Windows.Forms.DataGridView dataGridViewStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripGroupLabel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button buttonClearing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearchYear;
        private System.Windows.Forms.TextBox textBoxSearchTeacher;
        private System.Windows.Forms.Label label1;
    }
}