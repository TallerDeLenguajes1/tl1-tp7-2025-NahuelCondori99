using System.Globalization;
using InfoEmpleados;

Empleados miEmpleado = new Empleados
(
    "Nahuel",
    "Condori",
    's',
    750000,
    new DateTime(1999, 07, 15),
    new DateTime(2021, 03, 16),
    cargo: Empleados.Cargos.Ingeniero

);

miEmpleado.mostrarDatos();
