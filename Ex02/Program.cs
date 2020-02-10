using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti un program care afiseaza minimul , respectiv maximul dintr-un array de lungime 10.

            int[] myArr = new int[10] { 12, 45, 26, 7, 56, 11, 99, 65, 23, 32 };
            int i;
            int maxval;
            int minval;

            int count = myArr.Length;
            minval = myArr[0];
            maxval = myArr[0];

            for(i=1; i<count; i++)
            {
                if (myArr[i] > maxval)
                {
                    maxval = myArr[i];
                }
                if (myArr[i] < minval)
                {
                    minval = myArr[i];
                }
            }
            Console.WriteLine("Valoare maxima este " + maxval);
            Console.WriteLine("Valoare minima este " + minval);





        }
    }
}
