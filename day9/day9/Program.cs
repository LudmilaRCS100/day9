using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9
{
    class Program
    {
        static void Main(string[] args)
        {
            Test TestaObjekts = new Test();
            //masina ford = new Test();
            //int rezultats = TestaObjekts.Saskaitisana(3, 7);//
            Test TestaObjekts2 = new Test();

            TestaObjekts.skaitlis = 3;
            TestaObjekts2.skaitlis = 6;

            Console.WriteLine("Izvade no TestaObjekta: " + TestaObjekts.skaitlis);
            Console.WriteLine("Izvade no TestaObjekta2: " + TestaObjekts2.skaitlis);
            //Console.WriteLine("Izvade no klases: " + rezultats);//
            Console.ReadLine();


        }
    }
}
