
namespace CourseWorkSort
{
    partial class FormInputCountry
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblContinent = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCapital = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxCapital = new System.Windows.Forms.TextBox();
            this.TbxArea = new System.Windows.Forms.TextBox();
            this.TbxPopulation = new System.Windows.Forms.TextBox();
            this.pnlCountry = new System.Windows.Forms.Panel();
            this.dudContinent = new System.Windows.Forms.DomainUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlCountry.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(13, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Название";
            // 
            // lblContinent
            // 
            this.lblContinent.AutoSize = true;
            this.lblContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblContinent.Location = new System.Drawing.Point(13, 223);
            this.lblContinent.Name = "lblContinent";
            this.lblContinent.Size = new System.Drawing.Size(114, 25);
            this.lblContinent.TabIndex = 1;
            this.lblContinent.Text = "Континент";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPopulation.Location = new System.Drawing.Point(13, 173);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(112, 25);
            this.lblPopulation.TabIndex = 2;
            this.lblPopulation.Text = "Население";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArea.Location = new System.Drawing.Point(13, 123);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(98, 25);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Площадь";
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCapital.Location = new System.Drawing.Point(13, 73);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(93, 25);
            this.lblCapital.TabIndex = 4;
            this.lblCapital.Text = "Столица";
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxName.Location = new System.Drawing.Point(144, 20);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(370, 30);
            this.TbxName.TabIndex = 1;
            this.TbxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxName_KeyPress);
            // 
            // TbxCapital
            // 
            this.TbxCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxCapital.Location = new System.Drawing.Point(144, 70);
            this.TbxCapital.Name = "TbxCapital";
            this.TbxCapital.Size = new System.Drawing.Size(370, 30);
            this.TbxCapital.TabIndex = 2;
            this.TbxCapital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxCapital_KeyPress);
            // 
            // TbxArea
            // 
            this.TbxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxArea.Location = new System.Drawing.Point(144, 120);
            this.TbxArea.Name = "TbxArea";
            this.TbxArea.Size = new System.Drawing.Size(370, 30);
            this.TbxArea.TabIndex = 3;
            this.TbxArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxArea_KeyPress);
            // 
            // TbxPopulation
            // 
            this.TbxPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxPopulation.Location = new System.Drawing.Point(144, 170);
            this.TbxPopulation.Name = "TbxPopulation";
            this.TbxPopulation.Size = new System.Drawing.Size(370, 30);
            this.TbxPopulation.TabIndex = 4;
            this.TbxPopulation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPopulation_KeyPress);
            // 
            // pnlCountry
            // 
            this.pnlCountry.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCountry.Controls.Add(this.dudContinent);
            this.pnlCountry.Controls.Add(this.lblName);
            this.pnlCountry.Controls.Add(this.TbxPopulation);
            this.pnlCountry.Controls.Add(this.lblCapital);
            this.pnlCountry.Controls.Add(this.TbxArea);
            this.pnlCountry.Controls.Add(this.lblArea);
            this.pnlCountry.Controls.Add(this.TbxCapital);
            this.pnlCountry.Controls.Add(this.lblPopulation);
            this.pnlCountry.Controls.Add(this.TbxName);
            this.pnlCountry.Controls.Add(this.lblContinent);
            this.pnlCountry.Location = new System.Drawing.Point(20, 25);
            this.pnlCountry.Name = "pnlCountry";
            this.pnlCountry.Size = new System.Drawing.Size(536, 270);
            this.pnlCountry.TabIndex = 0;
            // 
            // dudContinent
            // 
            this.dudContinent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dudContinent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dudContinent.Items.Add("Австралия");
            this.dudContinent.Items.Add("Антарктида");
            this.dudContinent.Items.Add("Африка");
            this.dudContinent.Items.Add("Евразия");
            this.dudContinent.Items.Add("Северная_Америка");
            this.dudContinent.Items.Add("Южная_Америка");
            this.dudContinent.Location = new System.Drawing.Point(144, 221);
            this.dudContinent.Name = "dudContinent";
            this.dudContinent.ReadOnly = true;
            this.dudContinent.Size = new System.Drawing.Size(370, 30);
            this.dudContinent.TabIndex = 6;
            this.dudContinent.Wrap = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(20, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(436, 315);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 35);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Создать";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormInputCountry
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(576, 369);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormInputCountry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод информации о стране";
            this.pnlCountry.ResumeLayout(false);
            this.pnlCountry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContinent;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.TextBox TbxCapital;
        private System.Windows.Forms.TextBox TbxArea;
        private System.Windows.Forms.TextBox TbxPopulation;
        private System.Windows.Forms.Panel pnlCountry;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DomainUpDown dudContinent;
    }
}