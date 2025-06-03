namespace InfoEmpleados;


class Empleados
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    private string nombre;
    private string apellido;
    private char estadoCivil;
    private double sueldoBasico;
    private DateTime FechNac;
    private DateTime FechIngre;
    private Cargos cargo;

    public Empleados(string nombre, string apellido, char estadoCivil, double sueldoBasico, DateTime FechNac, DateTime FechIngre, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.estadoCivil = estadoCivil;
        this.sueldoBasico = sueldoBasico;
        this.FechNac = FechNac;
        this.FechIngre = FechIngre;
        this.cargo = cargo;
    }

    public string Nombre { get => nombre; }
    public string Apellido { get => apellido; }
    public char EstadoCivil { get => estadoCivil; }
    public double SueldoBasico { get => sueldoBasico; }
    public DateTime FechNac1 { get => FechNac; }
    public DateTime FechIngre1 { get => FechIngre; }
    private Cargos Cargo { get => cargo; }

    public void mostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Apellido: " + apellido);
        Console.WriteLine("Estado Civil: " + estadoCivil);
        Console.WriteLine("Sueldo Básico: " + sueldoBasico);
        Console.WriteLine("Fecha de Nacimiento: " + FechNac.ToShortDateString());
        Console.WriteLine("Fecha de Ingreso: " + FechIngre.ToShortDateString());
        Console.WriteLine("Cargo: " + cargo);
    }
}