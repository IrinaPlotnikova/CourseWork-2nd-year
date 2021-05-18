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
    public partial class FormInputSortInformation : Form
    {
        public FormInputSortInformation(string input)
        {
            InitializeComponent();

            DialogResult = DialogResult.Cancel;
            TbxInput.Text = input;
            TbxInput.ReadOnly = true;
            CbxSortType.SelectedIndex = 0;
        }

        public string OutputFilename { get; private set; }
        public int NumberOfWays { get; private set; }
        public bool IsBalanced { get; private set; }
 

        // подтверждение ввода информации для сортировки 
        private void btnOk_Click(object sender, EventArgs e)
        {
            string output = TbxOutput.Text.TrimEnd();
            if (OutputFilename == "")
            {
                MessageBox.Show("Название файла не должно быть пустой строкой.",
                                "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // если имя файла не пусто
            {
                OutputFilename = output + ".txt";
                NumberOfWays = Convert.ToInt32(NudWays.Value);
                IsBalanced = CbxSortType.SelectedIndex == 0;
                DialogResult = DialogResult.OK;
                Close();
            }
        }


        // обработка нажатия клавиши при вводе названия файла
        private void TbxOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            string forbiddenSymbols = "\\/:*?\"<>|"; // запрещенные символы
            e.Handled = forbiddenSymbols.Contains(e.KeyChar) ||
                        e.KeyChar == ' ' && TbxInput.Text == "" ||
                        e.KeyChar != (char)Keys.Back && TbxInput.Text.Length == 31;
        }
    }
}
