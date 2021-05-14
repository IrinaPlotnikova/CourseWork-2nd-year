using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkSort
{
    class Country : IComparable
    {
        private string name;       // название страны 
        private string capital;    // название столицы
        private string continent;  // название континента
        private int area;          // площадь в км^2
        private int population;    // численность 
        private static readonly Random rnd = new Random();
      

        // конструктор с параметром типа string
        // string information содержит корректную информацию о стране
        public Country(string information)
        {
            string[] info = information.Split();
            info = info.Where(x => x != "").ToArray();
            name = info[0];
            capital = info[1];
            area = Convert.ToInt32(info[2]);
            population = Convert.ToInt32(info[3]);
            continent = info[4];
        }


        // свойство для названия страны 
        public string Name {
            get => name;
            set => name = GetTransformed(value);
        }


        // свойство для названия столицы 
        public string Capital
        {
            get => capital;
            set => capital = GetTransformed(value);
        }


        // свойство для площади
        public int Area
        {
            get => area;
            set => area = Math.Max(0, value);
        }


        // свойство для численности населения
        public int Population
        {
            get => population;
            set => population = Math.Max(0, value);
        }


        // свойство для континента
        public string Continent
        {
            get => continent;
            set => continent = GetTransformed(value);
        }


        // преобразование страны к строке
        override public string ToString()
        {
            return Name + ' ' + Capital + ' ' + Continent + ' ' + Area.ToString() + ' ' + Population.ToString();
        }


        // генерация случайной страны
        public void Generate()
        {
            name = GenerateRandomString(5, 10);
            capital = GenerateRandomString(4, 10);
            area = rnd.Next(18000000) + 10;
            population = rnd.Next(400000000) + 10;
            continent = GetRandomContinent();
        }


        // сравнение стран по названию
        public int CompareTo(object obj)
        {
            Country county = (Country)(obj);
            return name.CompareTo(county.name);
        }


        // преобразовывает строку, убирает пробелы с краев, внутренние заменяет на '_'
        private string GetTransformed(string value)
        {
            string result = value.Trim(' ');
            result.Replace(' ', '_');
            return result != "" ? result : "_";
        }

        
        // возвращает случайный континент
        private string GetRandomContinent()
        { 
            string[] continents = new string[] { "", "", "", "", "" };
            return continents[rnd.Next(5)];
        }


        // генерирует случайную строку случайной длины из интервала [minLength; maxLength]
        private string GenerateRandomString(int minLength, int maxLength)
        {
            if (minLength < 0 || minLength > maxLength || maxLength == 0)
                return "";

            int length = minLength + rnd.Next(maxLength - minLength + 1);
            string result = "";
            result += 'A' + rnd.Next(26);  
            for (int i = 1; i < length; i++)
                result += 'a' + rnd.Next(26);
            return result;
        }
    }
}
