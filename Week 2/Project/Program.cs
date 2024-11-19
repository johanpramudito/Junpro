using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kumpulanAngka = { 23, 1, 43, 323, 6, 3, 13, 54, 2 };
            foreach (int angka in kumpulanAngka)
            {
                Console.Write($"{angka.ToString()} ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

