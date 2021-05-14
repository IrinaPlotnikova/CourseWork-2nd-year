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
        private Country lastElement;  // крайний элемент в последовательности для чтения
        private StreamReader reader;  // последовательность для чтения
        private StreamWriter writer;  // последовательность для записи

        // конструктор
        public Sequence()
        {
            EOF = false;
            EOS = false;
            lastElement = null;
            reader = null;
            writer = null;
        }

        // открывает последовательность для чтения, 
        // считывает первый элемент
        // возвращает true, если последовательности не пуста, иначе — false
        // filename — корректный файл, содержащий последовательность
        public bool StartRead(string filename)
        {
            CloseRead(); // закрыть послетовательность для чтения, если она открыта
            reader = new StreamReader(filename);
            string info = reader.ReadLine();
            if (info != null)
                lastElement = new Country(info);
            EOF = lastElement != null;
            EOS = EOF;
            return EOF;
        }

        // считывание следующего элемента в последовательности
        public void NextRead()
        {
            if (reader != null)
            {
                
                string info = reader.ReadLine();
                if (info != null)
                {
                    Country tmp = lastElement;
                    lastElement = new Country(info);
                    EOS = tmp != null && tmp.CompareTo(lastElement) > 0; 
                }
                else
                {
                    lastElement = null;
                    EOF = true;
                    EOS = true;
                }
            }
        }


        // открывает последовательность для записи,
        // filename — файл, в который будет записана последовательность
        public void StartWrite(string filename)
        {
            CloseWrite(); // закрыть послетовательность для записи, если она открыта
            writer = new StreamWriter(filename);
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
                lastElement = null;
            }
        }


        // закрывает последовательность для записи
        public void CloseWrite()
        {
            if (writer != null)
            {
                writer.Close();
                writer = null;
                lastElement = null;
            }
        }

    }
}
