
namespace CourseWorkSort
{
    partial class FormInputFileName
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
            this.lblFilename = new System.Windows.Forms.Label();
            this.tbxFilename = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlFilename = new System.Windows.Forms.Panel();
            this.lblExtension = new System.Windows.Forms.Label();
            this.pnlFilename.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFilename.Location = new System.Drawing.Point(13, 20);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(99, 25);
            this.lblFilename.TabIndex = 0;
            this.lblFilename.Text = "Название";
            // 
            // tbxFilename
            // 
            this.tbxFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFilename.Location = new System.Drawing.Point(129, 17);
            this.tbxFilename.Name = "tbxFilename";
            this.tbxFilename.Size = new System.Drawing.Size(155, 30);
            this.tbxFilename.TabIndex = 1;
            this.tbxFilename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFilename_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(250, 114);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 35);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Создать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(20, 114);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnlFilename
            // 
            this.pnlFilename.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilename.Controls.Add(this.lblExtension);
            this.pnlFilename.Controls.Add(this.lblFilename);
            this.pnlFilename.Controls.Add(this.tbxFilename);
            this.pnlFilename.Location = new System.Drawing.Point(20, 25);
            this.pnlFilename.Name = "pnlFilename";
            this.pnlFilename.Size = new System.Drawing.Size(350, 67);
            this.pnlFilename.TabIndex = 0;
            // 
            // lblExtension
            // 
            this.lblExtension.BackColor = System.Drawing.SystemColors.Window;
            this.lblExtension.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExtension.Location = new System.Drawing.Point(285, 17);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(42, 31);
            this.lblExtension.TabIndex = 1;
            this.lblExtension.Text = ".txt";
            this.lblExtension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormInputFileName
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(392, 168);
            this.Controls.Add(this.pnlFilename);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInputFileName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод названия файла";
            this.pnlFilename.ResumeLayout(false);
            this.pnlFilename.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox tbxFilename;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlFilename;
        private System.Windows.Forms.Label lblExtension;
    }
}