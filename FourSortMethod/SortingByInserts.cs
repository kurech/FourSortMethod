using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSortMethod
{
    public class SortingByInserts
    {
        public static int[] InsertionMethod(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j;
                int buf = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buf)
                        break;

                    array[j + 1] = array[j];
                }
                array[j + 1] = buf;
            }
            return array;
        }
    }
}
