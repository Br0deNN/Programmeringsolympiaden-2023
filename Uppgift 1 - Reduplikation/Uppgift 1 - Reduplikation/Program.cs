using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Text;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordet ?");
            string ord = Console.ReadLine();
            Console.WriteLine("Antal upprepningar ?");
            int x = int.Parse(Console.ReadLine());

            if (ord.Length <= 9 && x <= 9)
            {


                StringBuilder sb = new StringBuilder(ord.Length * x);
                for (int i = 0; i < x; i++)
                {
                    sb.Append(ord);
                }
                string svar = sb.ToString();
                Console.WriteLine("Svar: " + svar);
            }
            else
            {
                Console.WriteLine("Ordet får max vara 9 bokstäver långt och får max upprepas 9 gånger");
            }
            Console.ReadKey();
        }
    }
}