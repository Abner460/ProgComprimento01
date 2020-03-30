using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progcomprimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Comprimento comp = new Comprimento(200.0);

            System.Console.WriteLine(comp.Metro + " metros");
            System.Console.WriteLine(comp.Milha + " Milhas");

            System.Console.ReadKey();
        }
    }
}
