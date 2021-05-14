using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkSort
{
    public partial class FormInputFileName : Form
    {
        public FormInputFileName()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Input = "";
        }

        // введенное пользователем название
        public string Input { get; private set; }

        // обработка нажатия на клавишу при вводе название
        private void tbxFilename_KeyPress(object sender, KeyPressEventArgs e)
        {
            string forbiddenSymbols = "\\/:*?\"<>|"; // запрещенные символы
            e.Handled = forbiddenSymbols.Contains(e.KeyChar) ||
                        e.KeyChar == ' ' && tbxFilename.Text == "" ||
                        e.KeyChar != (char)Keys.Back && tbxFilename.Text.Length == 31;
        }

        // обработка кнопки подтверждения ввода
        private void btnOk_Click(object sender, EventArgs e)
        {
            string filename = tbxFilename.Text.TrimEnd();
            if (filename == "")
            {
                MessageBox.Show("Название файла не должно быть пустой строкой.",
                                "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // если имя файла не пусто
            {
                Input = filename;
                DialogResult = DialogResult.Yes;
                Close();
            }
        }
    }
}
