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
    public partial class FormInputCountry : Form
    {
        public FormInputCountry()
        {
            InitializeComponent();
            Input = null;
            DialogResult = DialogResult.Cancel;
            dudContinent.SelectedIndex = 0;
        }

        public Country Input { get; private set; }


        // название страны содержит не более 31 символа, состоит из любых символов
        private void TbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ' && TbxName.Text == "" ||
                        e.KeyChar != (char)Keys.Back && TbxName.Text.Length == 31;
        }


        // название столицы содержит не более 31 символа, состоит из любых символов
        private void TbxCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ' && TbxCapital.Text == "" ||
                        e.KeyChar != (char)Keys.Back && TbxCapital.Text.Length == 31;
        }


        // площадь — целое число [0; 999 999 999]
        private void TbxArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) && TbxArea.Text.Length <= 8 || 
                            e.KeyChar == (char)Keys.Back);
        }


        // население — целое число [0; 999 999 999]
        private void TbxPopulation_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) && (TbxPopulation.Text.Length <= 8) ||
                           e.KeyChar == (char)Keys.Back);
        }


        // подтверждение создания страны
        private void btnOk_Click(object sender, EventArgs e)
        {
            bool isCorrect = TbxName.Text != "" && TbxCapital.Text != "" &&
                             TbxArea.Text != "" && TbxPopulation.Text != "";
            if (!isCorrect)
            {
                MessageBox.Show("Присутствуют пустые строки.",
                                "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // если ввод корректен
            {
                Input = new Country();
                Input.Name = TbxName.Text;
                Input.Capital = TbxCapital.Text;
                Input.Area = Convert.ToInt32(TbxArea.Text);
                Input.Population = Convert.ToInt32(TbxPopulation.Text);
                Input.Continent = dudContinent.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
