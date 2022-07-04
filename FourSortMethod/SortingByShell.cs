using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSortMethod
{
    public class SortingByShell
    {
        public static int[] ShellMethod(int[] array)
        {
            var d = array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (array[j - d] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - d]);
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            return array;
        }

        public static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }
    }
}
