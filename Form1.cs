using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWorkSort
{
    public partial class Form1 : Form
    {
        private string initialDirectory = "D:\\ВГУ 2\\Курсовые\\2 курс, Внешняя сортировка\\CourseWorkSort\\Files";
        private string path;
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = "D:\\ВГУ 2\\Курсовые\\2 курс, Внешняя сортировка\\CourseWorkSort\\Files";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
        }


        // подтверждение пользователем действия
        private bool IsConfirm(string question)
        {
            DialogResult result = MessageBox.Show(question, "Подтверждение действия",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }


        // создание файла
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputFileName form = new FormInputFileName();
            Hide();
            form.ShowDialog();
            Show();

            string path = form.Input;
            // если создание подверждено и файла с таким названием нет 
            // или подтверждена перезапись
            if (form.DialogResult == DialogResult.OK && (!File.Exists(path) ||
                IsConfirm("Файл \"" + path + "\" существует. Перезаписать?")))
            {
                FileStream file = File.Create(initialDirectory + '\\' + path);
                file.Close();
                rtbLog.Text = "Файл \"" + path + "\" создан.\n" + rtbLog.Text;
            }
            else // если отменено создание или перезапись
            {
                rtbLog.Text = "Отмена создания файла.\n" + rtbLog.Text;
            }
        }


        // открыть файл
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                rtbLog.Text = "Файл \"" + path + "\" открыт.\n" + rtbLog.Text;
            }
            else
            {
                rtbLog.Text = "Отмена открытия файла.\n" + rtbLog.Text;
            }
        }

     
        // добавить элемент в файл
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                rtbLog.Text = "Невозможно выполнить добавление. Отсутствует открытый файл.\n" + 
                              rtbLog.Text;
            }
            else
            {
                FormInputCountry form = new FormInputCountry();
                Hide();
                form.ShowDialog();
                Show();
                
                if (form.DialogResult == DialogResult.Cancel)
                {
                    rtbLog.Text = "Отмена добавления страны.\n" + rtbLog.Text;
                }
                else
                {
                    StreamWriter writer = new StreamWriter(path);
                    writer.WriteLine(form.Input);
                    writer.Close();
                    rtbLog.Text = "Страна добавлена.\n" + rtbLog.Text;
                }
            }
        }

    
    }
}
