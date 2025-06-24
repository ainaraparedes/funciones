using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PersonaDireccion
{
    public class Direccion
    {
        public int Num { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        
       

        public Direccion(string calle, int num, string ciudad)
        {
            Num = num;
            Calle = calle;
            Ciudad = ciudad;
        }

        public override string ToString()
        {
            return $"{Num} {Calle}, {Ciudad}";
        }
    }
    
    
}
