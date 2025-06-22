using System;
using EspacioEmpleado;

Empleado[] empleados = new Empleado[3];
DateTime FechaAux;

Console.WriteLine("\n\t\t---TALLER DE LENGUAJES I---");
Console.WriteLine("\n\tCARGA DE DATOS DE LOS EMPLEADOS");
for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine($"\n\t\tCargando los datos del empleado {i+1}");
    empleados[i] = new Empleado();
    bool ok = 0;
    string entrada;

    // Ingreso el nombre del empleado
    do
    {
        Console.Write("\n\tNombre:\t");
        entrada = Console.ReadLine();
        if (empleados[i].AsignarNombre(entrada)){
            break;
        }else{
            Console.WriteLine("\n\t\t---Error no es posible asignar un valor vacio");
        }
    } while (true);

    // ingreso del apellido del empleado
    do
    {
        Console.Write("\n\tApellido:\t");
        entrada = Console.ReadLine();
        if(empleados[i].AsignarApellido(entrada)){
            break;
        }else{
            Console.WriteLine("\n\t\t---Error no es posible asignar un valor vacio");
        }
    } while (true);

    // ingreso de la fecha de nacimiento
    do
    {
        Console.Write("\n\tFecha de nacimiento (dd/mm/yyyy):\t");
        entrada = Console.ReadLine();
        ok = DateTime.TryParse(entrada, out FechaAux);
        if (ok && empleados[i].AsignarFechaNacimiento(FechaAux))
        {
            break;
        }else{
            Console.WriteLine("\n\t\t---Formato o fecha invalida");
        }
    } while (true);

    // ingreso de la fecha de ingreso al trabajo
    do
    {
        Console.Write("\n\tFecha de ingreso (dd/mm/yyyy):\t");
        entrada = Console.ReadLine();
        ok = DateTime.TryParse(entrada, out FechaAux);
        if (ok && empleados[i].AsignarFechaIngreso(FechaAux))
        {
            break;
        }else{
            Console.WriteLine("\n\t\t---Formato o fecha invalida");
        }
    } while (true);

    
    

}