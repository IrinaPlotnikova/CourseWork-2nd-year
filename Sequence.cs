using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseWorkSort
{
    class Sequence
    {
        // достигнут ли конец последовательности для чтения
        public bool EOF { get; private set; }
        // достигнут ли конец серии последовательности для чтения
        public bool EOS { get; private set; }  
        public Country LastElement { get; private set; }  // крайний элемент в последовательности для чтения
        private StreamReader reader;  // последовательность для чтения
        private StreamWriter writer;  // последовательность для записи
        private string filename;
        public string Filename 
        {
            get => filename;
            set 
            {
                CloseRead();
                CloseWrite();
                filename = value;
            } 
        }

        // конструктор
        public Sequence()
        {
            EOF = false;
            EOS = false;
            LastElement = null;
            reader = null;
            writer = null;
            filename = null;
        }

        // открывает последовательность для чтения, 
        // считывает первый элемент
        // возвращает true, если последовательности не пуста, иначе — false
        // filename — корректный файл, содержащий последовательность
        public bool StartRead()
        {
            if (reader != null || writer != null || filename == null)
                return false;

            reader = new StreamReader(filename);
            string info = reader.ReadLine();
            if (info != null)
                LastElement = new Country(info);
            EOF = LastElement != null;
            EOS = EOF;
            return true;
        }

        // считывание следующего элемента в последовательности
        public bool NextRead()
        {
            if (reader == null)
                return false;
            string info = reader.ReadLine();
            if (info != null)
            {
                Country tmp = LastElement;
                LastElement = new Country(info);
                EOS = tmp != null && tmp.CompareTo(LastElement) > 0; 
            }
            else
            {
                LastElement = null;
                EOF = true;
                EOS = true;
            }
            return true;
        }


        // открывает последовательность для записи,
        // filename — файл, в который будет записана последовательность
        public bool StartWrite()
        {
            if (reader != null || writer != null || filename == null)
                return false;
            writer = new StreamWriter(filename);
            return true;
        }

        public bool Write(Country value)
        {
            if (writer == null)
                return false;
            writer.WriteLine(value);
            return true;
        }


        // закрывает последовательность для чтения
        public void CloseRead()
        {
            if (reader != null)
            {
                reader.Close();
                EOF = false;
                EOS = false;
                reader = null;
                LastElement = null;
            }
        }


        // закрывает последовательность для записи
        public void CloseWrite()
        {
            if (writer != null)
            {
                writer.Close();
                writer = null;
                LastElement = null;
            }
        }

    }
}
