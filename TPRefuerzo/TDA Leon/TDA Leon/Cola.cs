using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Leon
{
    class Cola
    {
        int co;
        public void TieneCola ()
        {
            if (co != null)
            {
                Console.WriteLine("El león tiene cola.");
            }
            else
            {
                Console.WriteLine("No tiene cola ¿como la habrá perdido?");
            }
            return;
        }
    }
}
