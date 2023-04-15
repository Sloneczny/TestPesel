using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pesel
{
    class Program
    {
        static void Main(string[] args)
        {
            PESELWalidator z = new PESELWalidator("96111002015");
            z.Plec();
            Console.WriteLine(z.Plec());
            z.DataUrodzenia();
            z.Plec();


        }
    }
}
