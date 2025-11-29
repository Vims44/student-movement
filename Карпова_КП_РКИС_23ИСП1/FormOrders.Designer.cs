
namespace Карпова_КП_РКИС_23ИСП1
{
    partial class FormOrders
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПриказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьПриказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПриказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOrders = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelOrders = new System.Windows.Forms.ToolStripLabel();
            this.dataGridViewStud = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStripOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStud)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(11, 54);
            this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersWidth = 51;
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1479, 370);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.dataGridViewOrders_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1556, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПриказToolStripMenuItem,
            this.редактироватьПриказToolStripMenuItem,
            this.удалитьПриказToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // добавитьПриказToolStripMenuItem
            // 
            this.добавитьПриказToolStripMenuItem.Name = "добавитьПриказToolStripMenuItem";
            this.добавитьПриказToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.добавитьПриказToolStripMenuItem.Text = "Добавить приказ";
            this.добавитьПриказToolStripMenuItem.Click += new System.EventHandler(this.добавитьПриказToolStripMenuItem_Click);
            // 
            // редактироватьПриказToolStripMenuItem
            // 
            this.редактироватьПриказToolStripMenuItem.Name = "редактироватьПриказToolStripMenuItem";
            this.редактироватьПриказToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.редактироватьПриказToolStripMenuItem.Text = "Редактировать приказ";
            this.редактироватьПриказToolStripMenuItem.Click += new System.EventHandler(this.редактироватьПриказToolStripMenuItem_Click);
            // 
            // удалитьПриказToolStripMenuItem
            // 
            this.удалитьПриказToolStripMenuItem.Name = "удалитьПриказToolStripMenuItem";
            this.удалитьПриказToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.удалитьПриказToolStripMenuItem.Text = "Удалить приказ";
            this.удалитьПриказToolStripMenuItem.Click += new System.EventHandler(this.удалитьПриказToolStripMenuItem_Click);
            // 
            // toolStripOrders
            // 
            this.toolStripOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripOrders.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelOrders});
            this.toolStripOrders.Location = new System.Drawing.Point(0, 755);
            this.toolStripOrders.Name = "toolStripOrders";
            this.toolStripOrders.Size = new System.Drawing.Size(1556, 25);
            this.toolStripOrders.TabIndex = 2;
            this.toolStripOrders.Text = "toolStrip1";
            // 
            // toolStripLabelOrders
            // 
            this.toolStripLabelOrders.Name = "toolStripLabelOrders";
            this.toolStripLabelOrders.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabelOrders.Text = "toolStripLabel1";
            // 
            // dataGridViewStud
            // 
            this.dataGridViewStud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewStud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStud.Location = new System.Drawing.Point(8, 469);
            this.dataGridViewStud.Name = "dataGridViewStud";
            this.dataGridViewStud.ReadOnly = true;
            this.dataGridViewStud.RowHeadersWidth = 51;
            this.dataGridViewStud.RowTemplate.Height = 24;
            this.dataGridViewStud.Size = new System.Drawing.Size(891, 250);
            this.dataGridViewStud.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Приказы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Студенты с данным приказом";
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 780);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewStud);
            this.Controls.Add(this.toolStripOrders);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOrders";
            this.Text = "Приказы";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripOrders.ResumeLayout(false);
            this.toolStripOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripOrders;
        private System.Windows.Forms.ToolStripLabel toolStripLabelOrders;
        private System.Windows.Forms.DataGridView dataGridViewStud;
        private System.Windows.Forms.ToolStripMenuItem добавитьПриказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьПриказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПриказToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}