using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pppzZadatakDva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prijestupne godine od 1900. do 2100. su:");
            for (int i = 1900; i <= 2100; i++)
            {
                if (i % 400 == 0 || i % 4 == 0)
                {
                    if (i % 100 != 0) {
                        Console.WriteLine(i+" ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
