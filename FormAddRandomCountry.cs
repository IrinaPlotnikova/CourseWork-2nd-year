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
    public partial class FormAddRandomCountry : Form
    {
        public FormAddRandomCountry()
        {
            InitializeComponent();
            Input = 1;
            DialogResult = DialogResult.Cancel;
        }

        public int Input { get; private set; }

        // количество создаваемых случайных стран — целое число [1; 999 999 999]
        private void TbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) && TbxAmount.Text.Length <= 8 ||
                          e.KeyChar == (char)Keys.Back);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (TbxAmount.Text == "" || Convert.ToInt32(TbxAmount.Text) == 0)
            {
                MessageBox.Show("Введены некорректные данные.", "Некорректный ввод", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Input = Convert.ToInt32(TbxAmount.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
