using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseWorkSort
{
    class ExternalSorting
    {
        private int NumberOfWays;   // количество путей, используемых для слияния (>= 2)
        private Sequence[,] Sequences;       // последовательности с сериями

        public ExternalSorting(int numberOfWays)
        {
            NumberOfWays = Math.Max(numberOfWays, 2);

            Sequences = new Sequence[2, NumberOfWays];
            SetFilenamesForSequences();
        }

        // сортировка естественным многопутевым однофазным слиянием
        // Input — корректное название файла, который необходимо отсортировать
        // Output — корректное название файла, в котором сохраняются отсортированные данные
        // IsBalanced — является ли сортировка сбалансированной
        public void Sort(string Input, string Output, bool IsBalanced)
        {
            CreateAuxiliaryFiles();
            Sequences[0, 0].Filename = Input;

            int NumberOfSerieses; 
            int IndexFrom = 0;
            if (IsBalanced)
                NumberOfSerieses = SortPhaseBalanced(IndexFrom);
            else
                NumberOfSerieses = SortPhaseNotBalanced(IndexFrom);

            if (NumberOfSerieses > 1) // если файл не отсортирован
            {
                Sequences[0, 0].Filename = "0";
                while (NumberOfSerieses > 1) // пока файл не отсортирован
                {
                    IndexFrom = IndexFrom ^ 1; // первый индекс последовательностей для слияния
                    if (IsBalanced)
                        NumberOfSerieses = SortPhaseBalanced(IndexFrom);
                    else
                        NumberOfSerieses = SortPhaseNotBalanced(IndexFrom);
                }
            }

            File.Copy(Sequences[IndexFrom ^ 1, 0].Filename, Output, true);
            DeleteAuxiliaryFiles();
        }


        // фаза сортировки (несбалансированная сортировка)
        // IndexFrom — индекс, по которому находятся последовательности, серии из которых необходио слить
        // возвращает количество серий, в которые удалось слить последовательности
        private int SortPhaseNotBalanced(int IndexFrom)
        {
            OpenSequences(IndexFrom);  

            int NumberOfSequences = GetNumberOfSequences(IndexFrom);

            // индексы, в которых есть последовательности в Sequences
            int[] Indices = new int[NumberOfSequences];
            for (int i = 0; i < NumberOfSequences; i++)
                Indices[i] = i;

            int NextSeriesNumber = 0; // номер следующей слитой серии
            while (NumberOfSequences != 0)
            {
                int ResultIndex = NextSeriesNumber % NumberOfWays;
                Merge(IndexFrom, ResultIndex, ref Indices, ref NumberOfSequences);
                NextSeriesNumber++;
            }

            CloseSequences(IndexFrom);

            return NextSeriesNumber;
        }

        // фаза сортировки (сбалансированная сортировка)
        // IndexFrom — индекс, по которому находятся последовательности, серии из которых необходио слить
        // возвращает количество серий, в которые удалось слить последовательности
        private int SortPhaseBalanced(int IndexFrom)
        {
            OpenSequences(IndexFrom);

            int NumberOfSequences = GetNumberOfSequences(IndexFrom);
           
            // индексы, в которых есть последовательности в Sequences
            int[] Indices = new int[NumberOfSequences];
            for (int i = 0; i < NumberOfSequences; i++)
                Indices[i] = i;

            int NextSeriesNumber = 0; // номер следующей слитой серии
            while (NumberOfSequences > 0) // пока слиты не все последовательности
            {
                int MinIndex = GetIndexOfMinElement(IndexFrom, Indices, NumberOfSequences);
                Country FirstElementInSeries = Sequences[IndexFrom, Indices[MinIndex]].LastElement;

                int ResultIndex = NextSeriesNumber % NumberOfWays;

                // если серия продолжается, то сливаем, не увеличивая число серий
                if (IsSeriesContinues(Sequences[IndexFrom ^ 1, ResultIndex], FirstElementInSeries))
                    Merge(IndexFrom, ResultIndex, ref Indices, ref NumberOfSequences);

                if (NumberOfSequences > 0) // если слиты не все последовательности
                {
                    Merge(IndexFrom, ResultIndex, ref Indices, ref NumberOfSequences);
                    NextSeriesNumber++;
                }
            }

            CloseSequences(IndexFrom);

            return NextSeriesNumber;
        }


        // слияние крайних серий в одну серию
        // IndexFrom — индекс, по которому находятся последовательности, серии из которых необходио слить
        // IndexResult — индекс последовательности, в которую произойдет слияние. (IndexFrom ^ 1, IndexResult)
        // Indices — индексы, в которых есть последовательности в Sequences
        // NumberOfSequences — количество последовательностей с файлами
        private void Merge(int IndexFrom, int IndexResult, ref int[] Indices, ref int NumberOfSequences)
        {
            int IndexTo = IndexFrom ^ 1;
            // количество последовательностей с незакончившейся серией
            int NumberOfActiveSequences = NumberOfSequences;
            while (NumberOfActiveSequences != 0)
            {
                int MinIndex = GetIndexOfMinElement(IndexFrom, Indices, NumberOfActiveSequences);
                // записываем минимальный элемент в серию
                Sequences[IndexTo, IndexResult].Write(Sequences[IndexFrom, Indices[MinIndex]].LastElement);
                // считываем следующий элемент в последовательности, из которой произошла запись
                Sequences[IndexFrom, Indices[MinIndex]].NextRead();
                
                // если достигнут конец последовательности
                if (Sequences[IndexFrom, Indices[MinIndex]].EOF)
                {
                    NumberOfSequences--;
                    NumberOfActiveSequences--;

                    Indices[MinIndex] = Indices[NumberOfActiveSequences];
                    Indices[NumberOfActiveSequences] = Indices[NumberOfSequences];
                }
                else if (Sequences[IndexFrom, Indices[MinIndex]].EOS)
                {
                    // если конец серии, но не последовательности
                    NumberOfActiveSequences--;

                    int tmp = Indices[MinIndex];
                    Indices[MinIndex] = Indices[NumberOfActiveSequences];
                    Indices[NumberOfActiveSequences] = tmp;
                }
            }
        }


        // возвращает индекс из массива Indices, 
        // с помощью которого можно найти индекс последовательности с минимальным крайним элементом
        private int GetIndexOfMinElement(int IndexFrom, int[] Indices, int NumberOfActiveSequences)
        {
            int result = 0;
            for (int i = 1; i < NumberOfActiveSequences; i++)
            {
                if (Sequences[IndexFrom, Indices[result]].LastElement.CompareTo(Sequences[IndexFrom, Indices[i]].LastElement) > 0)
                {
                    result = i;
                }
            }
            return result;
        }


        // открытие последовательностей
        private void OpenSequences(int IndexFrom)
        {
            int IndexTo = IndexFrom ^ 1;
            for (int i = 0; i < NumberOfWays; i++)
            {
                Sequences[IndexFrom, i].StartRead();
            }
            for (int i = 0; i < NumberOfWays; i++)
            {
                Sequences[IndexTo, i].StartWrite();
            }
        }


        // закрытие последовательностей
        private void CloseSequences(int IndexFrom)
        {
            int IndexTo = IndexFrom ^ 1;
            for (int i = 0; i < NumberOfWays; i++)
            {
                Sequences[IndexFrom, i].CloseRead();
            }
            for (int i = 0; i < NumberOfWays; i++)
            {
                Sequences[IndexTo, i].CloseWrite();
            }
        }


        // возвращает число непустых последовательностей с первым индексом IndexFrom
        private int GetNumberOfSequences(int IndexFrom)
        {
            int result = 0;
            while (result < NumberOfWays && !Sequences[IndexFrom, result].EOF)
                result++;
            return result;
        }


        // устанавлиет последовательностям названия файлов, с которыми они связаны
        // названия: "0", "1", ..., "2 * NumberOfWays - 1" без расширения "txt",
        // что позволит избежать перезаписи файлов, так как в программе
        // пользователь может создать / открыть только файлы с расщирением "txt"
        private void SetFilenamesForSequences()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < NumberOfWays; j++)
                {
                    Sequences[i, j] = new Sequence();
                    Sequences[i, j].Filename = (i * NumberOfWays + j).ToString();
                }
            }
        }


        // является ли новая серия продолжением предыдущей
        private bool IsSeriesContinues(Sequence previos, Country current)
        {
            return previos.LastElement != null && previos.LastElement.CompareTo(current) <= 0;
        }


        // cоздание вспомогательных файлов
        // названия: "0", "1", ..., "2 * NumberOfWays - 1" без расширения "txt"
        // что позволит избежать перезаписи файлов, так как в программе
        // пользователь может создать / открыть только файлы с расщирением "txt"
        private void CreateAuxiliaryFiles()
        {
            for (int i = 0; i < 2 * NumberOfWays; i++)
            {
                StreamWriter Writer = new StreamWriter(i.ToString());
                Writer.Close();
            }
        }


        // удаление вспомогательных файлов
        // названия: "0", "1", ..., "2 * NumberOfWays - 1" без расширения "txt"
        private void DeleteAuxiliaryFiles()
        {
            for (int i = 0; i < 2 * NumberOfWays; i++)
            {
                File.Delete(i.ToString());
            }
        }

    }
}
