using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaDireccion
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public int Edad { get; set; }
        public Direccion Direccion { get; set; }
        public Persona (string nombre, string apellido, int dni, int edad, Direccion direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Edad = edad;
            Direccion = direccion;
        }

        public void InfoPersona()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Dni: {Dni}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
        }

        public override string ToString()
        {

            return $"Nombre: {Nombre}, Apellido: {Apellido}, Dni: {Dni}, Edad: {Edad}, Direccion: {Direccion}";
        }

    }
}
