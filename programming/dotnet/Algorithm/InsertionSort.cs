using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSort
    { 
        public void InsertionSortMethod()
        {
            Console.Write("enter the size ot String array : ");
            int len = Utility.Util.ReadInt();

            String[] array = new String[len];

            Console.WriteLine(" enter the array : ");
            Utility.Util.InputStringArray(array);

            Console.Write(" entered array is : ");
            Utility.Util.PrintStringArray(array);

            DoInsertionSort(array);

            Console.Write("after insertion sort : ");
            Utility.Util.PrintStringArray(array);

        }

        void DoInsertionSort(String[] array)
        {
            int j = 0;
            String key ="";
            for(int i=0;i<array.Length;i++)
            {
                key = array[i];
                j = i-1;
                while(j>=0)
                {
                    if(array[j].CompareTo(key)==1)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                array[j + 1] = key;
            }

        }

    }
}
