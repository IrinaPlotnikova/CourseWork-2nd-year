
namespace CourseWorkSort
{
    partial class FormInputSortInformation
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
            this.PnlInformation = new System.Windows.Forms.Panel();
            this.NudWays = new System.Windows.Forms.NumericUpDown();
            this.LblWays = new System.Windows.Forms.Label();
            this.LblExtension2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.TbxOutput = new System.Windows.Forms.TextBox();
            this.LblExtensionInput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.TbxInput = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxSortType = new System.Windows.Forms.ComboBox();
            this.PnlInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWays)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlInformation
            // 
            this.PnlInformation.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PnlInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlInformation.Controls.Add(this.CbxSortType);
            this.PnlInformation.Controls.Add(this.label1);
            this.PnlInformation.Controls.Add(this.NudWays);
            this.PnlInformation.Controls.Add(this.LblWays);
            this.PnlInformation.Controls.Add(this.LblExtension2);
            this.PnlInformation.Controls.Add(this.lblOutput);
            this.PnlInformation.Controls.Add(this.TbxOutput);
            this.PnlInformation.Controls.Add(this.LblExtensionInput);
            this.PnlInformation.Controls.Add(this.lblInput);
            this.PnlInformation.Controls.Add(this.TbxInput);
            this.PnlInformation.Location = new System.Drawing.Point(20, 25);
            this.PnlInformation.Name = "PnlInformation";
            this.PnlInformation.Size = new System.Drawing.Size(394, 212);
            this.PnlInformation.TabIndex = 4;
            // 
            // NudWays
            // 
            this.NudWays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NudWays.Location = new System.Drawing.Point(143, 110);
            this.NudWays.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NudWays.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NudWays.Name = "NudWays";
            this.NudWays.Size = new System.Drawing.Size(232, 30);
            this.NudWays.TabIndex = 6;
            this.NudWays.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // LblWays
            // 
            this.LblWays.AutoSize = true;
            this.LblWays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblWays.Location = new System.Drawing.Point(13, 110);
            this.LblWays.Name = "LblWays";
            this.LblWays.Size = new System.Drawing.Size(58, 25);
            this.LblWays.TabIndex = 5;
            this.LblWays.Text = "Пути";
            // 
            // LblExtension2
            // 
            this.LblExtension2.BackColor = System.Drawing.SystemColors.Window;
            this.LblExtension2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblExtension2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblExtension2.Location = new System.Drawing.Point(333, 63);
            this.LblExtension2.Name = "LblExtension2";
            this.LblExtension2.Size = new System.Drawing.Size(42, 31);
            this.LblExtension2.TabIndex = 3;
            this.LblExtension2.Text = ".txt";
            this.LblExtension2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutput.Location = new System.Drawing.Point(13, 65);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(111, 25);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Результат";
            // 
            // TbxOutput
            // 
            this.TbxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxOutput.Location = new System.Drawing.Point(143, 63);
            this.TbxOutput.Name = "TbxOutput";
            this.TbxOutput.Size = new System.Drawing.Size(190, 30);
            this.TbxOutput.TabIndex = 4;
            this.TbxOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxOutput_KeyPress);
            // 
            // LblExtensionInput
            // 
            this.LblExtensionInput.BackColor = System.Drawing.SystemColors.Window;
            this.LblExtensionInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblExtensionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblExtensionInput.Location = new System.Drawing.Point(333, 17);
            this.LblExtensionInput.Name = "LblExtensionInput";
            this.LblExtensionInput.Size = new System.Drawing.Size(42, 31);
            this.LblExtensionInput.TabIndex = 1;
            this.LblExtensionInput.Text = ".txt";
            this.LblExtensionInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInput.Location = new System.Drawing.Point(13, 20);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(105, 25);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Исходный";
            // 
            // TbxInput
            // 
            this.TbxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxInput.Location = new System.Drawing.Point(143, 17);
            this.TbxInput.Name = "TbxInput";
            this.TbxInput.Size = new System.Drawing.Size(190, 30);
            this.TbxInput.TabIndex = 1;
            this.TbxInput.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(20, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(294, 256);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 35);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тип";
            // 
            // CbxSortType
            // 
            this.CbxSortType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSortType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CbxSortType.FormattingEnabled = true;
            this.CbxSortType.Items.AddRange(new object[] {
            "сбалансированная",
            "несбалансированная"});
            this.CbxSortType.Location = new System.Drawing.Point(143, 159);
            this.CbxSortType.Name = "CbxSortType";
            this.CbxSortType.Size = new System.Drawing.Size(232, 30);
            this.CbxSortType.TabIndex = 8;
            // 
            // FormInputSortInformation
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 308);
            this.Controls.Add(this.PnlInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInputSortInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация для сортировки";
            this.PnlInformation.ResumeLayout(false);
            this.PnlInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudWays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlInformation;
        private System.Windows.Forms.Label LblExtensionInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox TbxInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label LblExtension2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox TbxOutput;
        private System.Windows.Forms.NumericUpDown NudWays;
        private System.Windows.Forms.Label LblWays;
        private System.Windows.Forms.ComboBox CbxSortType;
        private System.Windows.Forms.Label label1;
    }
}