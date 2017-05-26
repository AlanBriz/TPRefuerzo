using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Leon
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuerpo c = new Cuerpo();
            Patas p = new Patas();
            Cola co = new Cola();
            Melena m = new Melena();

            c.TieneCuerpo();
            p.TienePatas();
            co.TieneCola();
            m.TieneMelena();
            Console.WriteLine("El león está completo");

            Console.ReadLine();
        }
    }
}
