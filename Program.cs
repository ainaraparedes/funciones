

namespace Empleados
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado empleado2 = new EmpleadoPermanente("Juan", 22, 310);
            Empleado empleado1 = new EmpleadoTemporal("Pedro", 170, 200);

            Console.WriteLine($"El empleado {empleado1.Nombre} cobra un sueldo de: {empleado1.CalcularSueldo()}");
            Console.WriteLine($"El empleado {empleado2.Nombre} cobra un sueldo de: {empleado2.CalcularSueldo()}");
                
        }
        
    }
}
