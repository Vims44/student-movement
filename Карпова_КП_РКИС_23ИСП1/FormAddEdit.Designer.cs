
namespace Карпова_КП_РКИС_23ИСП1
{
    partial class FormAddEdit
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
            this.textBoxAddEdit = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancellation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAddEdit
            // 
            this.textBoxAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.textBoxAddEdit.Location = new System.Drawing.Point(115, 37);
            this.textBoxAddEdit.Name = "textBoxAddEdit";
            this.textBoxAddEdit.Size = new System.Drawing.Size(221, 26);
            this.textBoxAddEdit.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonOk.Location = new System.Drawing.Point(36, 93);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(146, 39);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Подтвердить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancellation
            // 
            this.buttonCancellation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.buttonCancellation.Location = new System.Drawing.Point(208, 93);
            this.buttonCancellation.Name = "buttonCancellation";
            this.buttonCancellation.Size = new System.Drawing.Size(146, 39);
            this.buttonCancellation.TabIndex = 3;
            this.buttonCancellation.Text = "Отменить";
            this.buttonCancellation.UseVisualStyleBackColor = true;
            this.buttonCancellation.Click += new System.EventHandler(this.buttonCancellation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Статус:";
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 180);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancellation);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxAddEdit);
            this.Name = "FormAddEdit";
            this.Text = "FormAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxAddEdit;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancellation;
        private System.Windows.Forms.Label label1;
    }
}