using EspacioEmpleado;
using Internal;

Empleado[] empleados = new Empleado[3];

Console.WriteLine("\n\t\t---TALLER DE LENGUAJES I---");
Console.WriteLine("\n\tCARGA DE DATOS DE LOS EMPLEADOS");
for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine($"\n\t\tCargando los datos del empleado {i+1}");
    empleados[i] = new Empleado();
    bool ok = 0;
    string entrada;
    

}