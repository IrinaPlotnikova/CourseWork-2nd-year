
namespace CourseWorkSort
{
    partial class MainForm
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
            this.lbxFilename = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRandomCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InputCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.lblSize = new System.Windows.Forms.Label();
            this.TbxSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFilename = new System.Windows.Forms.TextBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbxFilename.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxFilename
            // 
            this.lbxFilename.BackColor = System.Drawing.SystemColors.Control;
            this.lbxFilename.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lbxFilename.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.SortToolStripMenuItem});
            this.lbxFilename.Location = new System.Drawing.Point(0, 0);
            this.lbxFilename.Name = "lbxFilename";
            this.lbxFilename.ShowItemToolTips = true;
            this.lbxFilename.Size = new System.Drawing.Size(762, 36);
            this.lbxFilename.TabIndex = 0;
            this.lbxFilename.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.ChangeToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(74, 32);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.CreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.CreateToolStripMenuItem.Text = "Создать..";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.OpenToolStripMenuItem.Text = "Открыть..";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // ChangeToolStripMenuItem
            // 
            this.ChangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ChangeToolStripMenuItem.Enabled = false;
            this.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            this.ChangeToolStripMenuItem.Size = new System.Drawing.Size(255, 32);
            this.ChangeToolStripMenuItem.Text = "Изменить";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRandomCountryToolStripMenuItem,
            this.InputCountryToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(220, 32);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // AddRandomCountryToolStripMenuItem
            // 
            this.AddRandomCountryToolStripMenuItem.Enabled = false;
            this.AddRandomCountryToolStripMenuItem.Name = "AddRandomCountryToolStripMenuItem";
            this.AddRandomCountryToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Q";
            this.AddRandomCountryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.AddRandomCountryToolStripMenuItem.Size = new System.Drawing.Size(370, 32);
            this.AddRandomCountryToolStripMenuItem.Text = "Случайным образом..";
            this.AddRandomCountryToolStripMenuItem.Click += new System.EventHandler(this.AddRandomCountryToolStripMenuItem_Click);
            // 
            // InputCountryToolStripMenuItem
            // 
            this.InputCountryToolStripMenuItem.Enabled = false;
            this.InputCountryToolStripMenuItem.Name = "InputCountryToolStripMenuItem";
            this.InputCountryToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.InputCountryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.InputCountryToolStripMenuItem.Size = new System.Drawing.Size(370, 32);
            this.InputCountryToolStripMenuItem.Text = "Через ввод..";
            this.InputCountryToolStripMenuItem.Click += new System.EventHandler(this.InputCountryToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Enabled = false;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.DeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(220, 32);
            this.DeleteToolStripMenuItem.Text = "Удалить..";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // SortToolStripMenuItem
            // 
            this.SortToolStripMenuItem.Enabled = false;
            this.SortToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SortToolStripMenuItem.Name = "SortToolStripMenuItem";
            this.SortToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.SortToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SortToolStripMenuItem.Size = new System.Drawing.Size(165, 32);
            this.SortToolStripMenuItem.Text = "Отсортировать";
            this.SortToolStripMenuItem.ToolTipText = "Ctrl+S";
            this.SortToolStripMenuItem.Click += new System.EventHandler(this.SortToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlAmount
            // 
            this.pnlAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmount.Controls.Add(this.lblSize);
            this.pnlAmount.Controls.Add(this.TbxSize);
            this.pnlAmount.Controls.Add(this.label1);
            this.pnlAmount.Controls.Add(this.tbxFilename);
            this.pnlAmount.Location = new System.Drawing.Point(16, 46);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(728, 69);
            this.pnlAmount.TabIndex = 8;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSize.Location = new System.Drawing.Point(448, 22);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(84, 25);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Размер";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TbxSize
            // 
            this.TbxSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TbxSize.Location = new System.Drawing.Point(545, 20);
            this.TbxSize.Name = "TbxSize";
            this.TbxSize.ReadOnly = true;
            this.TbxSize.Size = new System.Drawing.Size(155, 30);
            this.TbxSize.TabIndex = 9;
            this.TbxSize.TabStop = false;
            this.TbxSize.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Открытый файл";
            // 
            // tbxFilename
            // 
            this.tbxFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFilename.Location = new System.Drawing.Point(203, 19);
            this.tbxFilename.Name = "tbxFilename";
            this.tbxFilename.ReadOnly = true;
            this.tbxFilename.Size = new System.Drawing.Size(155, 30);
            this.tbxFilename.TabIndex = 7;
            this.tbxFilename.TabStop = false;
            this.tbxFilename.Text = "—";
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbLog.Location = new System.Drawing.Point(3, 3);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(719, 171);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.TabStop = false;
            this.rtbLog.Text = "Программа запущена.";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLog.Location = new System.Drawing.Point(12, 144);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(84, 25);
            this.lblLog.TabIndex = 11;
            this.lblLog.Text = "Журнал";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtbLog);
            this.panel1.Location = new System.Drawing.Point(17, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 179);
            this.panel1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAmount);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lbxFilename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.lbxFilename;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Многопутевое однофазное естественное слияние";
            this.lbxFilename.ResumeLayout(false);
            this.lbxFilename.PerformLayout();
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip lbxFilename;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem AddRandomCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InputCountryToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFilename;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox TbxSize;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Panel panel1;
    }
}

