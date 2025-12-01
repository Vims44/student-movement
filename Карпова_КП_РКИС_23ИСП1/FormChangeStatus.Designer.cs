
namespace Карпова_КП_РКИС_23ИСП1
{
    partial class FormChangeStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeStatus));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerChange = new System.Windows.Forms.DateTimePicker();
            this.labelfio = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.comboBoxNewGroup = new System.Windows.Forms.ComboBox();
            this.labelNewGroup = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(164, 182);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(271, 28);
            this.comboBoxStatus.TabIndex = 1;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            this.comboBoxStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxStatus_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Комментарий:";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(167, 330);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(303, 101);
            this.textBoxComment.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Дата приказа:";
            // 
            // dateTimePickerChange
            // 
            this.dateTimePickerChange.Location = new System.Drawing.Point(169, 461);
            this.dateTimePickerChange.Name = "dateTimePickerChange";
            this.dateTimePickerChange.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerChange.TabIndex = 5;
            // 
            // labelfio
            // 
            this.labelfio.AutoSize = true;
            this.labelfio.Location = new System.Drawing.Point(6, 28);
            this.labelfio.Name = "labelfio";
            this.labelfio.Size = new System.Drawing.Size(138, 20);
            this.labelfio.TabIndex = 6;
            this.labelfio.Text = "ФИО студента:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(6, 60);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(146, 20);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Дата рождения:";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(6, 91);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(72, 20);
            this.lblGroup.TabIndex = 8;
            this.lblGroup.Text = "Группа:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(36, 549);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(142, 41);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(227, 549);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(142, 41);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelfio);
            this.groupBox1.Controls.Add(this.lblBirthDate);
            this.groupBox1.Controls.Add(this.lblGroup);
            this.groupBox1.Location = new System.Drawing.Point(26, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 140);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студент:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Приказ:";
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Location = new System.Drawing.Point(163, 282);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(516, 28);
            this.comboBoxOrder.TabIndex = 13;
            this.comboBoxOrder.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrder_SelectedIndexChanged);
            this.comboBoxOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxOrder_KeyPress);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddOrder.Image")));
            this.buttonAddOrder.Location = new System.Drawing.Point(685, 275);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(47, 40);
            this.buttonAddOrder.TabIndex = 14;
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // comboBoxNewGroup
            // 
            this.comboBoxNewGroup.FormattingEnabled = true;
            this.comboBoxNewGroup.Location = new System.Drawing.Point(163, 234);
            this.comboBoxNewGroup.Name = "comboBoxNewGroup";
            this.comboBoxNewGroup.Size = new System.Drawing.Size(181, 28);
            this.comboBoxNewGroup.TabIndex = 9;
            this.comboBoxNewGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxNewGroup_KeyPress);
            // 
            // labelNewGroup
            // 
            this.labelNewGroup.AutoSize = true;
            this.labelNewGroup.Location = new System.Drawing.Point(29, 234);
            this.labelNewGroup.Name = "labelNewGroup";
            this.labelNewGroup.Size = new System.Drawing.Size(128, 20);
            this.labelNewGroup.TabIndex = 15;
            this.labelNewGroup.Text = "Новая группа:";
            // 
            // FormChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 653);
            this.Controls.Add(this.labelNewGroup);
            this.Controls.Add(this.comboBoxNewGroup);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormChangeStatus";
            this.Text = "Изменение статуса студента";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerChange;
        private System.Windows.Forms.Label labelfio;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.ComboBox comboBoxNewGroup;
        private System.Windows.Forms.Label labelNewGroup;
    }
}