using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    abstract class Empleado
    {
        public string Nombre { get; set; }

        public abstract double CalcularSueldo();
    }
}
