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
    public partial class FormRemoveCountry : Form
    {
        public FormRemoveCountry(int maxNumber)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            nudAmount.Minimum = 1;
            nudAmount.Maximum = maxNumber;
        }
          
        public int Input { get; private set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Input = Convert.ToInt32(nudAmount.Value);
            Close();
        }
    }
}
