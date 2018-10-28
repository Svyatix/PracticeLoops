using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramochka
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int nLength = Length(N);
            int tenPower = (int)Math.Pow(10, nLength - 1);

            int result = 0;
            while (N > 0)
            {
                int digit = N % 10;
                N /= 10;

                result += digit * tenPower;
                tenPower /= 10;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int Length(int number) {return (int)Math.Floor(Math.Log10(number)) + 1; }
        //----------------------------- Задание В -------------------------//
        static void zadanieB
        {
            int[] array = new int[13] { 1, 1, 1, 1, 1, 0, 2, 2, 2, 2, 3, 3, 3 };
            int[] arrayCounter = new int[4] { 0, 0, 0, 0 };
            int count = 1;
            int max = 0;
            int num = 0;
            bool trig = false;
            for (int i = 0; i < array.Length-1; i++)
            {
                 if (array[i] == array[i + 1])
                 {
                   count++;
                   if (max < count) max = count;
                 }
                 else
                   trig = true;
                                    
                 if (trig)
                 {
                    arrayCounter[num]=count;
                    num++;
                    trig = false;
                    count = 1;
                 }
            }
            int maxElem = arrayCounter[0];
            for (int i = 0; i < arrayCounter.Length; i++)
                if (arrayCounter[i] > maxElem) maxElem = arrayCounter[i];
            Console.WriteLine("Максимальная длина=" + maxElem);
            Console.ReadKey();
        }
    }
}
