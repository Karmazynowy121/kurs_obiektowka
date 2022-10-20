using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmySortowania
{


    public class Sort
    {
        int[] intArray;
        int[] intArray2;
        public Sort(int numberOfElementToSort = 5)
        {
            intArray = new int[numberOfElementToSort];
            intArray2 = new int[numberOfElementToSort];
            GenerateArrayValues();
            DuplicateArray();
            Console.WriteLine("Wyniki sortowanie dla algorytmu bombelkowego:");
            BubbleSort();
            for (int i = 0; i < numberOfElementToSort; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            ByChooseSort();
            Console.WriteLine("Wyniki sortowanie dla algorytmu przez wybór:");
            for (int i = 0; i < numberOfElementToSort; i++)
            {
                Console.WriteLine(intArray2[i]);
            }
        }

        private void DuplicateArray()
        {
            for (int i = 0; i < intArray.Length ; i++)
            {
                intArray2[i] = intArray[i];
            }
        }

        private void GenerateArrayValues()
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = new Random().Next(10);
            }
        }

        public void BubbleSort()
        {
            for (int i = 0; i < intArray.Length -1 ; i++)
            {
                int a1 = intArray[i];
                int a2 = intArray[i + 1];

                if (a1 > a2)
                {
                    intArray[i] = a2;
                    intArray[i + 1] = a1;
                }
            }

            if (CheckArrayCond())
            {
                return;
            }

            BubbleSort();
        }

        public void ByChooseSort()
        {
            for (int i = 0; i < intArray2.Length - 1; i++)
            {

                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray2[j] < intArray2[i])
                    {
                        int a1 = intArray2[i];
                        intArray2[i] = intArray2[j];
                        intArray2[j] = a1;

                    }
                }

            }

            if (CheckArrayCond())
            {
                return;
            }


        }

        bool CheckArrayCond()
        {
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (intArray[i] > intArray[i + 1])
                {
                    return false;
                }
            }

            return true;
        }

    }
}
