using System;
using EspacioEmpleado;

Empleado[] empleados = new Empleado[3];     /* arreglo de objetos */
int opcion;     /* entero auxiliar para el menu de opciones */
DateTime FechaAux;  /* variable auxiliar para las fechas ingresadas */
bool ok = false;    /* variable booleana para confirmar algunas cargas */
string entrada;     /* variable que es usada como entrada del taclado */

Console.WriteLine("\n\t\t---TALLER DE LENGUAJES I---");
Console.WriteLine("\n\tCARGA DE DATOS DE LOS EMPLEADOS");
for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine($"\n\t\tCargando los datos del empleado {i+1}");
    empleados[i] = new Empleado();  /* creacion del objeto empleado */

    // Ingreso el nombre del empleado
    do
    {
        Console.Write("\n\tNombre: ");
        entrada = Console.ReadLine();
        if (empleados[i].AsignarNombre(entrada)){   /* si la carga es valida sale del bucle sino un mensaje de error */
            break;
        }else{
            Console.WriteLine("\n\t\t---Error no es posible asignar un valor vacio, reingrese");
        }
    } while (true);

    // ingreso del apellido del empleado
    do
    {
        Console.Write("\n\tApellido: ");
        entrada = Console.ReadLine();
        if(empleados[i].AsignarApellido(entrada)){ /* si la carga es valida sale del bucle sino un mensaje de error */
            break;
        }else{
            Console.WriteLine("\n\t\t---Error no es posible asignar un valor vacio, reingrese");
        }
    } while (true);

    // ingreso de la fecha de nacimiento
    do
    {
        Console.Write("\n\tFecha de nacimiento (dd/mm/yyyy): ");
        entrada = Console.ReadLine();
        ok = DateTime.TryParse(entrada, out FechaAux);  /* aqui se verifica si la entrada es valida para usarse */
        if (ok && empleados[i].AsignarFechaNacimiento(FechaAux))    /* si la carga y el formato son validos salimos del bucle sino mensaje de error */
        {
            break;
        }else{
            Console.WriteLine("\n\t\t---Formato o fecha invalida, reingrese");
        }
    } while (true);

    // ingreso de la fecha de ingreso al trabajo
    do
    {
        Console.Write("\n\tFecha de ingreso (dd/mm/yyyy): ");
        entrada = Console.ReadLine();
        ok = DateTime.TryParse(entrada, out FechaAux);  /* aqui se verifica si es la entrada es valida para usarse */
        if (ok && empleados[i].AsignarFechaIngreso(FechaAux))   /* si la carga y el formato son validos salimos del bucle sino mensaje de error */
        {
            break;
        }else{
            Console.WriteLine("\n\t\t---Formato o fecha invalida, reingrese");
        }
    } while (true);

    // ingreso del estado civil
    do
    {
        /* estos son los estados civiles aceptados para el formulario */
        Console.Write("\n\t---Estado civil---\n\tSoltero/a = S\n\tCasado/a = C\n\tDivorciado/a = D\n\tViudo/a = V\n\tEstado: ");
        entrada = Console.ReadLine();
        if (empleados[i].AsignarEC(entrada[0]))    /* si la carga es exitosa salimos del bucle sino un mensje de error */
        {
            break;
        }else{
            Console.WriteLine("\n\t\t---Estado civil no valido, reingrese");
        }
    } while (true);
    
    // ingreso del cargo
    do
    {
        Console.WriteLine("\n\tSeleccione un cargo");
        int j = 0;  /* variable que sirve para numerar los cargos existentes en el enum */
        string[] ListaCargos = Enum.GetNames(typeof(Cargos));   /* creo un arreglo con los cargos del enum */
        foreach (string cargo in ListaCargos)   /* aquí listo los cargos del arreglo */
        {
            Console.WriteLine($"{++j}- {cargo}");
        }
        Console.Write("\n\tSeleccione un cargo: ");
        entrada = Console.ReadLine();   /* lectura de la entrada */
        if (int.TryParse(entrada, out int indice) && indice > 0 && indice <= ListaCargos.Length){ /* si la entrada es valida y esta en el rango de las opciones */
            Cargos cargoIngresado = (Cargos)(--indice); /* guardamos la opcion elegida */
            empleados[i].AsignarCargo(cargoIngresado);  /* uso el metodo para cargar el cargo seleccionado y salimos del bucle */
            break;
        }else{
            /* mensaje de error */
            Console.WriteLine("\n\t---Error indice invalido, reingrese");
        }
    } while (true);

    Console.WriteLine(new string('-', 50)); // separador visual

}

// // Empleado 1: Ingeniero, casado
// empleados[0] = new Empleado();
// empleados[0].AsignarNombre("Laura");
// empleados[0].AsignarApellido("Gómez");
// empleados[0].AsignarEC('C'); // casado
// empleados[0].AsignarFechaNacimiento(new DateTime(1975, 3, 15)); // 15/03/1975
// empleados[0].AsignarFechaIngreso(new DateTime(2000, 6,  1));    // 01/06/2000
// empleados[0].AsignarCargo(Cargos.Ingeniero);

// // Empleado 2: Auxiliar, soltero
// empleados[1] = new Empleado();
// empleados[1].AsignarNombre("Marcos");
// empleados[1].AsignarApellido("Pérez");
// empleados[1].AsignarEC('S'); // soltero
// empleados[1].AsignarFechaNacimiento(new DateTime(1990, 7, 22)); // 22/07/1990
// empleados[1].AsignarFechaIngreso(new DateTime(2018, 2, 10));    // 10/02/2018
// empleados[1].AsignarCargo(Cargos.Auxiliar);

// // Empleado 3: Especialista, viudo
// empleados[2] = new Empleado();
// empleados[2].AsignarNombre("Ana");
// empleados[2].AsignarApellido("Martínez");
// empleados[2].AsignarEC('V'); // viudo
// empleados[2].AsignarFechaNacimiento(new DateTime(1982, 11, 5)); // 05/11/1982
// empleados[2].AsignarFechaIngreso(new DateTime(2010, 9, 12));    // 12/09/2010
// empleados[2].AsignarCargo(Cargos.Especialista);

do
{
    Console.WriteLine("\n\t\t---MENU DE OPCIONES---");
    Console.WriteLine("\n\t1-Mostrar suma de salarios a pagar");
    Console.WriteLine("\n\t2-Mostrar el proximo a jubilarse");
    Console.WriteLine("\n\t3-Mostrar tabla de empleados");
    Console.WriteLine("\n\t4-Salir");
    Console.Write("\n\tOPCION:\t");
    entrada = Console.ReadLine();
    if (!int.TryParse(entrada, out opcion) || opcion < 1 || opcion > 4){
        Console.WriteLine("\n\tOpcion Invalida, REINGRESE");
        continue;
    }
    switch (opcion)
    {
        case 1:
            float salarios = 0.0f;
            for (int i = 0; i < empleados.Length; i++)
            {
                salarios+=empleados[i].CalcularSueldo();
            }
            Console.WriteLine($"Total a pagar en concepto de salarios: {salarios}");
            break;
        case 2:
            int indice = 0, edadBase = 0;
            for (int i = 0; i < empleados.Length; i++)
            {
                if (empleados[i].CalcularEdad() > edadBase)
                { 
                    edadBase = empleados[i].CalcularEdad();
                    indice = i;
                }
            }
            Console.WriteLine("\n\tEMPLEADO MAS PROXIMO A JUBILARSE");
            Console.WriteLine($"\n\tNombre completo: {empleados[indice].Nombre} {empleados[indice].Apellido}");
            Console.WriteLine($"\n\tEdad: {edadBase} años");
            Console.WriteLine($"\n\tCargo del empleado: {empleados[indice].CargoEmpleado}");
            Console.WriteLine($"\n\tAntiguedad: {empleados[indice].CalcularAntiguedad()} años");
            Console.WriteLine($"\n\tSalario: ${empleados[indice].CalcularSueldo()}");
            break;
        // case 3:
        //     Console.WriteLine("\n\t\t---EMPLEADOS---");
        //     Console.WriteLine($"\n\t{"NOMBRE",-15} {"APELLIDO",-11} {"ESTADO CIVIL",-14} {"EDAD",-5} {"ANTIGüEDAD",-8} {"CARGO",15} {"SUELDO",10}\n");
        //     foreach (Empleado obj in empleados)
        //     {
        //         Console.Write($"\t{obj.Nombre,-15} {obj.Apellido,-11} {obj.EstadoCivil,-14} {obj.CalcularEdad(),-5} {obj.CalcularAntiguedad() + " años",-13} {obj.CargoEmpleado, -15} {obj.CalcularSueldo(),10:F2}\n");
        //     }
        //     break;
    }

} while (opcion != 4);