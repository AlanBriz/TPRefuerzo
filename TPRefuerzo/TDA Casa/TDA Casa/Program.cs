using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDA_Casa
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, TDAAmbiente> CasaD;
            CasaD = new Dictionary<string, TDAAmbiente>();
            TDAAmbiente Cocina = new TDAAmbiente(1, 3, 4, "Cocina");
            CasaD.Add(Cocina.Ambiente, Cocina);
            CasaD = new Dictionary<string, TDAAmbiente>();
            TDAAmbiente Pieza = new TDAAmbiente(1, 1, 4, "Pieza");
            CasaD.Add(Pieza.Ambiente, Pieza);
            CasaD = new Dictionary<string, TDAAmbiente>();
            TDAAmbiente Living = new TDAAmbiente(2, 3, 4, "Living");
            CasaD.Add(Living.Ambiente, Living);

            foreach (string Elements in CasaD.Keys)
            {
                TDAAmbiente ambiente;
                CasaD.TryGetValue(Elements, out ambiente);
                Console.WriteLine("Habitación: " + ambiente.Ambiente);
                Console.WriteLine("Puertas: " + ambiente.Puertas);
                Console.WriteLine("Ventanas: " + ambiente.Ventanas);
                Console.WriteLine("Paredes: " + ambiente.Paredes);
                Console.ReadLine();
            }
        }
    }
}
