using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSortMethod
{
    public class SortingByChoice
    {
        public static int[] SelectionMethod(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min])
                    {
                        min = j;
                    }
                }
                int temp = mas[min];
                mas[min] = mas[i];
                mas[i] = temp;
            }
            return mas;
        }
    }
}
