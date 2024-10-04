using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Szamrendszerek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy 10-es számrendszerbeli számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            List<int> szamrendszer = new List<int>();

            int egy = 1, nulla = 0;


            while (szam != 0)
            {
                if (szam % 2 == 0) {
                    szamrendszer.Add(nulla);
                    szam -= 1;
                }

                else 
                { 
                    szamrendszer.Add(egy);
                    szam -= 1;
                }

            }
            Console.WriteLine(szamrendszer);
        }
    }
}
