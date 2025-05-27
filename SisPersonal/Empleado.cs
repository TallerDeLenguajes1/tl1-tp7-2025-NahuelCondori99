namespace InfoEmpleados;

public class InfoEmpleados
{
    private string nombre;
    private string apellido;
    private char estadoCivil;
    private double sueldoBasico;
    private DateTime FechNac;
    private DateTime FechIngre;

    private enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public string Nombre { get => nombre; }
    public string Apellido { get => apellido; }
    public char EstadoCivil { get => estadoCivil; }
    public double SueldoBasico { get => sueldoBasico; }
    public DateTime FechNac1 { get => FechNac; }
    public DateTime FechIngre1 { get => FechIngre; }


    public void NomEmpleado(string nombre)
    {
        nombre = Console.ReadLine();
    }
    public void ApEmpleado(string apellido)
    {
        apellido = Console.ReadLine();
    }
    public void FechNaci(DateTime fechaNac)
    {

    }
    public void Estado(char estadoCivil)
    {
        
    }
    public void Sueldo(double sueldoB)
    {

    }

    public void FechIn(DateTime fechaIn)
    {

    }
}