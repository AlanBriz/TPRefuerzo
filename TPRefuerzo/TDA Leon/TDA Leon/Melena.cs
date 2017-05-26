using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Leon
{
    class Melena
    {
        int m;
        public void TieneMelena()
        {
            if (m != null)
            {
                Console.WriteLine("El león tiene melena.");
            }
            else
            {
                Console.WriteLine("No tiene melena, debe ser hembra.");
            }
            return;
        }
    }
}
