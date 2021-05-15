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
        int numberOfCountries;
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = initialDirectory;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            path = null;
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

            string newPath = initialDirectory + '\\' + form.Input;
            // если создание подверждено и файла с таким названием нет 
            // или подтверждена перезапись
            if (form.DialogResult == DialogResult.OK && (!File.Exists(newPath) ||
                IsConfirm("Файл \"" + newPath + "\" существует. Перезаписать?")))
            {
                FileStream file = File.Create(newPath);
                file.Close();
                rtbLog.Text = "Файл \"" + newPath + "\" создан.\n" + rtbLog.Text;
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
                StreamReader reader = new StreamReader(path);
                numberOfCountries = 0;
                while (reader.ReadLine() != null)
                    numberOfCountries++;
                reader.Close();
            }
            else
            {
                rtbLog.Text = "Отмена открытия файла.\n" + rtbLog.Text;
            }
        }



        // добавить страну в файл через ввод
        private void InputCountryToolStripMenuItem_Click(object sender, EventArgs e)
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
                    StreamWriter writer = new StreamWriter(path, true);
                    writer.WriteLine(form.Input);
                    writer.Close();
                    numberOfCountries++;
                    rtbLog.Text = "Страна добавлена.\n" + rtbLog.Text;
                }
            }
        }


        // добавление случайных стран в файл
        private void AddRandomCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                rtbLog.Text = "Невозможно выполнить добавление. Отсутствует открытый файл.\n" +
                              rtbLog.Text;
            }
            else
            {
                FormAddRandomCountry form = new FormAddRandomCountry();
                Hide();
                form.ShowDialog();
                Show();

                if (form.DialogResult == DialogResult.Cancel)
                {
                    rtbLog.Text = "Отмена добавления страны.\n" + rtbLog.Text;
                }
                else
                {
                    int amount = form.Input;
                    numberOfCountries += amount;

                    StreamWriter writer = new StreamWriter(path, true);
                    for (int i = 0; i < amount; i++)
                    {
                        Country country = new Country();
                        country.Generate();
                        writer.WriteLine(country);
                    }
                    writer.Close();

                    rtbLog.Text = "Случайные страны добавлены (" + amount.ToString() + 
                        " шт.)\n" + rtbLog.Text;
                }
            }
        }


        // удаление страны из файла по индексу
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                rtbLog.Text = "Невозможно выполнить удаление. Отсутствует открытый файл.\n" +
                              rtbLog.Text;
            }
            else if (numberOfCountries == 0)
            {
                rtbLog.Text = "Невозможно выполнить удаление. Файл пуст.\n" + rtbLog.Text;
            }
            else
            {
                FormRemoveCountry form = new FormRemoveCountry(numberOfCountries);
                Hide();
                form.ShowDialog();
                Show();

                if (form.DialogResult == DialogResult.Cancel)
                {
                    rtbLog.Text = "Отмена удаления страны.\n" + rtbLog.Text;
                }
                else
                {
                    numberOfCountries--;

                    string tmpFilename = initialDirectory + "\\tmp";
                    StreamWriter writer = new StreamWriter(tmpFilename);
                    StreamReader reader = new StreamReader(path);
                    int index = form.Input - 1;

                    for (int i = 0; i < index; i++)
                    {
                        writer.WriteLine(reader.ReadLine());
                    }
                    reader.ReadLine(); // пропуск удаляемой страны
                    for (int i = index + 1; i < numberOfCountries; i++)
                    {
                        writer.WriteLine(reader.ReadLine());
                    }

                    reader.Close();
                    writer.Close();

                    File.Copy(tmpFilename, path, true);
                    File.Delete(tmpFilename);
                    
                    rtbLog.Text = "Страна с индексом " + form.Input.ToString() +
                                  " удалена.\n" + rtbLog.Text;
                }
            }
        }

        // нажание на кнопку меню "Отсортировать"
        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                rtbLog.Text = "Невозможно выполнить сортировку. Отсутствует открытый файл.\n" +
                              rtbLog.Text;
            }
            else
            {
                int first = path.LastIndexOf('\\');
                int last = path.LastIndexOf('.') - 1;
                string input = path.Substring(first, last - first + 1);
                FormInputSortInformation form = new FormInputSortInformation(input);
                form.ShowDialog();

                string outputPath = form.OutputFilename;

                if (form.DialogResult == DialogResult.OK && (!File.Exists(outputPath) ||
                    IsConfirm("Файл \"" + outputPath + "\" существует. Перезаписать?")))
                {
                    // сортировка
                }
                else
                {
                    rtbLog.Text = "Отмена сортировка.\n" + rtbLog.Text;
                }
            }
        }
    }
}
