using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Leon
{
    class Cuerpo
    {
        int c;
        internal void TieneCuerpo()
        {
            if (c != null)
            {
                Console.WriteLine("El león tiene cuerpo, menos mal.");
            }
            else
            {
                Console.WriteLine("No tiene cuerpo, pobre.");
            }
            return;
        }
    }
}
