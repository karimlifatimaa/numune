using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmis ededin reqemlerinin hasilini tapin.
            int eded = 59998;
            int hasil = 1;
            while (eded !=0)
            {
                int qaliq = eded % 10;
                hasil *= qaliq;
                eded = eded - qaliq;
                eded = eded / 10;
            }
            Console.WriteLine(hasil);
           
        }
    }
}
