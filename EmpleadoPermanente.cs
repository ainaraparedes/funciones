using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Empleados
{
    class EmpleadoPermanente : Empleado
    {
        public int CantDias { get; set; }
        public double ValorDia { get; set; }

        public EmpleadoPermanente(string nombre, int cantDias, double valorDia)
        {
            Nombre = nombre;
            CantDias = cantDias;
            ValorDia = valorDia;
        }
        public override double CalcularSueldo()
        {
            return CantDias * ValorDia;
        }
    }
}
