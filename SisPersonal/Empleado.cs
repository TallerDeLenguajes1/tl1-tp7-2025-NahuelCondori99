using System.Diagnostics.CodeAnalysis;

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
    private DateTime fechNac;
    private DateTime fechIngre;
    private Cargos cargo;

    public Empleados(string nombre, string apellido, char estadoCivil, double sueldoBasico, DateTime fechNac, DateTime fechIngre, Cargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.estadoCivil = estadoCivil;
        this.sueldoBasico = sueldoBasico;
        this.fechNac = fechNac;
        this.fechIngre = fechIngre;
        this.cargo = cargo;
    }


    public string Nombre { get => nombre; }
    public string Apellido { get => apellido; }
    public char EstadoCivil { get => estadoCivil; }
    public double SueldoBasico { get => sueldoBasico; }
    public DateTime FechNac { get => fechNac; }
    public DateTime FechIngre { get => fechIngre; }
    public Cargos Cargo { get => cargo; }


    //EJERCICIO 2
    public int edad => DateTime.Now.Year - fechNac.Year;
    public int antiguedad => DateTime.Now.Year - fechIngre.Year;
    public int jubilacion => 65 - edad;

    public double CalcSalario()
    {
        double adicional = 0;

        if (antiguedad < 21)
        {
            adicional = sueldoBasico * (antiguedad * 0.01);
        }
        else
        {
            adicional = sueldoBasico * 0.25;
        }

        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional = adicional * 1.5;
        }

        if (char.ToUpper(estadoCivil) == 'C')
        {
            adicional += 150000;
        }

        double salarioTotal = sueldoBasico + adicional;

        return salarioTotal;
    }

    public void MostrarDatos()
    {
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Apellido: " + apellido);
        Console.WriteLine("Estado Civil: " + estadoCivil);
        Console.WriteLine("Sueldo Básico: $ " + sueldoBasico);
        Console.WriteLine("Fecha de Nacimiento: " + fechNac.ToShortDateString());
        Console.WriteLine("Fecha de Ingreso: " + fechIngre.ToShortDateString());
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Edad del empleado: " + edad + " anios");
        Console.WriteLine("Salario del empleado: $" + CalcSalario());
        Console.WriteLine("Antiguedad del empleado en la empresa: " + antiguedad + " anios");
        Console.WriteLine("Anios restantes para jubilarse: " + jubilacion);
        Console.WriteLine("---------------------------------");
    }
    
}