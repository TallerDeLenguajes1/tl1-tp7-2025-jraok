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

    // ingreso del estado civil
    do
    {
        Console.Write("\n\t---Estado civil---\n\tSoltero/a = S\n\tCasado/a = C\n\tDivorciado/a = D\n\tViudo/a = V");
        entrada = Console.ReadLine();
        if (empleados[i].AsignarEC(entrada))
        {
            break;
        }else{
            Console.WriteLine("\n\t\t---Estado civil no valido");
        }
    } while (true);
    
    // ingreso del cargo
    do
    {
        Console.WriteLine("\n\tSeleccione un cargo");
        int j = 0;
        string[] ListaCargos = Enum.GetNames(typeof(Cargos));
        foreach (string cargo in ListaCargos)
        {
            Console.WriteLine($"{++j}- {cargo}");
        }
        Console.Write("\n\tCargo: ");
        entrada = Console.ReadLine();
        if (int.TryParse(entrada, out int indice) && indice > 0 && indice <= ListaCargos.Length){
            Cargos cargoIngresado = (Cargos)(--indice);
            empleados[i].AsignarCargo(cargoIngresado);
            break;
        }else{
            Console.WriteLine("\n\t---Error indice invalido");
        }
    } while (true);
    

}