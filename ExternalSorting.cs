using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkSort
{
    class ExternalSorting
    {
        // сортировка естественным многопутевым однофазным слиянием
        // Input — корректное название файла, который необходимо отсортировать
        // Output — корректное название файла, в котором сохраняются отсортированные данные
        // NumberOfWays — количество путей, используемых для слияния
        // IsBalanced — является ли сортировка сбалансированной
        public void Sort(string Input, string Output, int NumberOfWays,  bool IsBalanced)
        {
            Sequence[,] Sequences = new Sequence[2, NumberOfWays];
            SetFilenamesForSequences(ref Sequences, NumberOfWays);
            Sequences[0, 0].Filename = Input;

            int NumberOfSerieses;
            int IndexFrom = 0;
            if (IsBalanced)
                NumberOfSerieses = SortPhaseBalanced(ref Sequences, IndexFrom, NumberOfWays);
            else
                NumberOfSerieses = SortPhaseNotBalanced(ref Sequences, IndexFrom, NumberOfWays);
            if (NumberOfSerieses > 1)
            {
                Sequences[0, 0].Filename = "0";
                while (NumberOfSerieses != 1)
                {
                    IndexFrom = IndexFrom ^ 1;
                    if (IsBalanced)
                        NumberOfSerieses = SortPhaseBalanced(ref Sequences, IndexFrom, NumberOfWays);
                    else
                        NumberOfSerieses = SortPhaseNotBalanced(ref Sequences, IndexFrom, NumberOfWays);
                   
                }
            }
        }


        // фаза сортировки (несбалансированная сортировка)
        // Sequences — последовательности с сериями
        // IndexFrom — индекс, по которому находятся последовательности, серии из которых необходио слить
        // NumberOfWays — количество путей, используемых для слияния
        // возвращает количество серий, в которые удалось слить последовательности
        int SortPhaseNotBalanced(ref Sequence[,] Sequences, int IndexFrom, int NumberOfWays)
        {
            for (int i = 0; i < NumberOfWays; i++)
                Sequences[IndexFrom, i].StartRead();

            int NumberOfSequences = 0;
            while (NumberOfSequences < NumberOfWays && !Sequences[IndexFrom, NumberOfSequences].EOF)
                NumberOfSequences++;

            int NextSeriesIndex = 0; // номер следующей слитой серии
            while (NumberOfSequences != 0)
            {
                // индексы, в которых есть последовательности в Sequences
                int[] Indices = new int[NumberOfSequences];
                for (int i = 0; i < NumberOfSequences; i++)
                    Indices[i] = i;

                NumberOfSequences = Merge(ref Sequences, IndexFrom, NextSeriesIndex % NumberOfWays, 
                                          ref Indices, NumberOfSequences);
                NextSeriesIndex++;
            }

            for (int i = 0; i < NumberOfSequences; i++)
                Sequences[IndexFrom, i].CloseRead();

            return NextSeriesIndex; 
        }

        // фаза сортировки (сбалансированная сортировка)
        // Sequences — последовательности с сериями
        // IndexFrom — индекс, по которому находятся последовательности, серии из которых необходио слить
        // NumberOfWays — количество путей, используемых для слияния
        // Indices — индексы, в которых есть последовательности в Sequences
        // возвращает количество серий, в которые удалось слить последовательности
        int SortPhaseBalanced(ref Sequence[,] Sequences, int IndexFrom, int NumberOfWays)
        {
            for (int i = 0; i < NumberOfWays; i++)
                Sequences[IndexFrom, i].StartRead();

            int NumberOfSequences = 0;
            while (NumberOfSequences < NumberOfWays && !Sequences[IndexFrom, NumberOfSequences].EOF)
                NumberOfSequences++;

            int IndexTo = IndexFrom ^ 1;
            int NextSeriesIndex = 0; // номер следующей слитой серии
            while (NumberOfSequences != 0)
            {
                // индексы, в которых есть последовательности в Sequences
                int[] Indices = new int[NumberOfSequences];
                for (int i = 0; i < NumberOfSequences; i++)
                    Indices[i] = i;

                int MinIndex = GetIndexOfMinElement(ref Sequences, IndexFrom, Indices, NumberOfSequences);
                Country FirstElementInSeries = Sequences[IndexFrom, MinIndex].LastElement;
                
                // если серия продолжается
                if (Sequences[IndexTo, NextSeriesIndex % NumberOfWays] != null &&
                    Sequences[IndexTo, NextSeriesIndex % NumberOfWays].LastElement.CompareTo(FirstElementInSeries) <= 0)
                    NumberOfSequences = Merge(ref Sequences, IndexFrom, NextSeriesIndex % NumberOfWays,
                                              ref Indices, NumberOfSequences);
                
                if (NumberOfSequences > 0) // если слиты не все последовательности
                {
                    Merge(ref Sequences, IndexFrom, NextSeriesIndex % NumberOfWays, ref Indices, NumberOfSequences);
                    NextSeriesIndex++;
                }
            }
            for (int i = 0; i < NumberOfSequences; i++)
                Sequences[IndexFrom, i].CloseRead();
            return NextSeriesIndex;
        }



        // слияние крайних серий в одну серию
        // Sequences — последовательности с сериями
        // IndexFrom — индекс, по которому находятся последовательности, серии из которых необходио слить
        // IndexResult — индекс последовательности, в которую произойдет слияние. (IndexFrom ^ 1, IndexResult)
        // Indices — индексы, в которых есть последовательности в Sequences
        // NumberOfSequences — количество последовательностей с сериями
        private int Merge(ref Sequence[,] Sequences, int IndexFrom, int IndexResult, ref int[] Indices, int NumberOfSequences)
        {
            int IndexTo = IndexFrom ^ 1;
            // количество последовательностей с незакончившейся серией
            int NumberOfActiveSequences = NumberOfSequences; 
            while (NumberOfActiveSequences != 0)
            {
                int MinIndex = GetIndexOfMinElement(ref Sequences, IndexFrom, Indices, NumberOfActiveSequences);
                // записываем минимальный элемент в серию
                Sequences[IndexTo, IndexResult].Write(Sequences[IndexFrom, Indices[MinIndex]].LastElement);
                // считываем следующий элемент в последовательности, из которой произошла запись
                Sequences[IndexFrom, Indices[MinIndex]].NextRead();
                // если достигнут конец последовательности
                if (Sequences[IndexFrom, Indices[MinIndex]].EOF)
                {
                    NumberOfSequences--;
                    NumberOfActiveSequences--;
                    // перемещаем индекс еще не закончившейся последовательности
                    Indices[MinIndex] = Indices[NumberOfSequences];
                }
                else if (Sequences[IndexFrom, Indices[MinIndex]].EOS) 
                {
                    // если конец серии, но не последовательности
                    NumberOfActiveSequences--;
                    // меняем местами индексы последовательностей с 
                    int tmp = Indices[MinIndex]; 
                    Indices[MinIndex] = Indices[NumberOfActiveSequences];
                    Indices[NumberOfSequences] = tmp;
                }
            }
            return NumberOfSequences;
        }
     

        // возвращает индекс из массива Indices, 
        // с помощью которого можно найти индекс последовательности с минимальным крайним элементом
        private int GetIndexOfMinElement(ref Sequence[,] Sequences, int IndexFrom, int[] Indices, int NumberOfActiveSequences)
        {
            int result = 0;
            for (int i = 1; i < NumberOfActiveSequences; i++)
            {
                if (Sequences[IndexFrom, result].LastElement.CompareTo(Sequences[IndexFrom, Indices[i]].LastElement) > 0)
                {
                    result = i;
                }
            }
            return result;
        }

    


        // устанавлиет последовательностям названия файлов, с которыми они связаны
        // названия: "0", "1", ..., "2 * NumberOfWays - 1" без расширения "txt",
        // что позволит избежать перезаписи файлов, так как в программе
        // пользователь может создать / открыть только файлы с расщирением "txt"
        private void SetFilenamesForSequences(ref Sequence[,] Sequences, int NumberOfWays)
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


        // прогонка серии

        // слияние серий в одну

        public void SortNotBalanced(string Input, string OutPut, int NumberOfWays)
        {

        }
    }
}
