using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class Perro : Animal
    {
        public string Nombre { get; set; }
        public Perro (string nombre)
        {
            Nombre = nombre;
        }
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre}: Guau guau.");
        }
    }
}
