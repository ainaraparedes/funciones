using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class EmpleadoTemporal : Empleado
    {
        public double Horas { get; set; }
        public double ValorHora { get; set; }

        public EmpleadoTemporal (string nombre, double horas, double valorHora)
        {
            Nombre = nombre;
            Horas = horas;
            ValorHora = valorHora;
        }

        public override double CalcularSueldo()
        {
            return Horas * ValorHora;
        }
    }

}
