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

    // Ingreso el nombre del empleado
    do
    {
        Console.Write("\n\tNombre:\t");
        entrada = Console.ReadLine();
        if (empleados[i].AsignarNombre(entrada))
        {
            break;
        }else
        {
            Console.WriteLine("\n\t\t---Error no es posible asignar un valor vacio");
        }
    } while (true);

    do
    {
        Console.Write("\n\tApellido:\t");
        entrada = Console.ReadLine();
        if(empleados[i].AsignarApellido(entrada)){
            break;
        }else
        {
            Console.WriteLine("\n\t\t---Error no es posible asignar un valor vacio");
        }
    } while (true);

    do
    {
        Console.Write("\n\tApellido:\t");
        entrada = Console.ReadLine();
    } while (true);
    do
    {
        Console.Write("\n\tApellido:\t");
        entrada = Console.ReadLine();
    } while (true);
    do
    {
        Console.Write("\n\tApellido:\t");
        entrada = Console.ReadLine();
    } while (true);

}