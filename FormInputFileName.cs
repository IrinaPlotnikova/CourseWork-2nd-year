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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string forbiddenSymbols = "\\/:*?\"<>|";
            e.Handled = forbiddenSymbols.Contains(e.KeyChar) || 
                        textBox1.Text == "" && e.KeyChar == ' ' || 
                        textBox1.Text.Length == 31 && e.KeyChar != (char)Keys.Back;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
