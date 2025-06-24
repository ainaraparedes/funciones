namespace PersonaDireccion
{
    class Program
    {
       static void Main()
        {
            Direccion dirLucas = new Direccion("Rivadavia",600, "Rafaela");
            Persona Lucas = new Persona("Lucas", "Perez", 46890345, 21, dirLucas);

            Lucas.InfoPersona();
        }
    }
}