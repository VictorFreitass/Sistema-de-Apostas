using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Apostas
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de cartões");
            string c = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de número para cartões");
            int n = int.Parse(Console.ReadLine());
            int[,] m = new int[c, n];

        }
    }
}
