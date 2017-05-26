using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Casa
{
    class TDAAmbiente
    {
        public int Puertas;
        public int Ventanas;
        public int Paredes;
        public string Ambiente;

        public TDAAmbiente(int Puertas, int Ventanas, int Paredes, string Ambiente)
        {
            TDATecho Techo = new TDATecho();
            TDAPiso Piso = new TDAPiso();
            for(int i = 0; i < Ventanas; i++)
            {
                AddVentana();
            }
            for (int i = 0; i < Paredes; i++)
            {
                AddPared();
            }
            for (int i = 0; i < Puertas; i++)
            {
                AddPuerta();
            }
            this.Ambiente = Ambiente;
        }

        private void AddPuerta()
        {
            Puertas++;
        }

        private void AddPared()
        {
            Paredes++;
        }

        private void AddVentana()
        {
            Ventanas++;
        }
    }
}
