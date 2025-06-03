using System.Globalization;
using InfoEmpleados;

Empleados[] miEmpleado = new Empleados[3];

    miEmpleado[0] = new Empleados("Elias", "Condori", 'C', 650000, new DateTime(1999, 7, 15), new DateTime(2010, 3, 15), Empleados.Cargos.Ingeniero);

    miEmpleado[1] = new Empleados("Santos", "Condori", 'C', 850000, new DateTime(2000, 10, 1), new DateTime(2022, 4, 15), Empleados.Cargos.Administrativo);

    miEmpleado[2] = new Empleados("Nahuel", "Condori", 'S', 750000, new DateTime(2001, 7, 16), new DateTime(2019, 7, 15), Empleados.Cargos.Administrativo);

double montoSalarioTotal = 0;

for (int i = 0; i < miEmpleado.Length; i++)
{
    miEmpleado[i].MostrarDatos();

    montoSalarioTotal += miEmpleado[i].CalcSalario();
}
Console.WriteLine("El monto total en conceptos de salarios es: $" + montoSalarioTotal);
Console.WriteLine("---------------------------------");
Empleados jubiMaxima = miEmpleado[0];

for (int i = 0; i < miEmpleado.Length; i++)
{
    if (miEmpleado[i].jubilacion < jubiMaxima.jubilacion)
    {
        jubiMaxima = miEmpleado[i];
    }
}
Console.WriteLine("El empleado mas proximo a jubilarse es: ");
jubiMaxima.MostrarDatos();