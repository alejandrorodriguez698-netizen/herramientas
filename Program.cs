public class Program 
{
    static void Main()
    {
        Console.WriteLine("Hola, mundo"); 
        Empleado empleado1 = new Empleado("Jean", "1011394463", "jeanpvalenciav@gmail.com", 20, 1000, "desarrollador");
        Console.WriteLine(empleado1.Cargo);

        empleado1.Cargo = "Developer";

        Console.WriteLine(empleado1.Cargo);

        empleado1.MostrarInfo();

        Console.WriteLine("=================");
        empleado1.CalcularSueldo("hola");
        Console.WriteLine("=================");
        empleado1.CalcularSueldo(0.4);

        
    }
}