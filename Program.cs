using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje2._1
{
    internal class Program
    {
        private static string abc;

        static void Main(string[] args)
        {

            Console.WriteLine("Unesite rečenicu: ");

             abc= Console.ReadLine();

           string abc1;
           abc1 =  abc.Replace(" ", "_");
            Console.WriteLine(abc1);

            Console.ReadKey();

        }
    }
}
