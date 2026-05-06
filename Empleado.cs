public class Empleado : Persona 
{
    private double sueldo;
    public string Cargo;
    public double Sueldo
    {
        get {return sueldo;}
        set {
            if(value >= 0)
            {
                sueldo = value;
            } else {
                Console.WriteLine("Sueldo no puede ser negativo!");
            }
        }
    }

    public Empleado (
            string nombre,
            string documento,
            string correo,
            int edad,
            double sueldo,
            string cargo 
        )
        :base(nombre, documento, correo, edad)
        {
            this.sueldo = sueldo;
            this.Cargo = cargo;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo(); // ejecuta el MostrarInfo() de Persona
            Console.WriteLine("Cargo: " + Cargo); // agrega lo propio de Empleado
            Console.WriteLine("Sueldo: $" + Sueldo.ToString("N0"));
        }

        public void CalcularSueldo(string tipo)
    {
        Console.WriteLine(this.sueldo * 0.1);
    }
        public void CalcularSueldo(Double descuento)
    {
        Console.WriteLine(this.sueldo * 0.1);
    }

}