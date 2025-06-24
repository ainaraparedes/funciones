using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    public class Program
    {
        static void Main()
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new Perro("Lola"));
            animales.Add(new Perro("Rocco"));

            foreach (var animal in animales)
            {
                animal.HacerSonido();
            }
        }
        
    }
}