﻿using System;
using EspacioEmpleado;

Empleado[] empleados = new Empleado[3];
DateTime FechaAux;

Console.WriteLine("\n\t\t---TALLER DE LENGUAJES I---");
Console.WriteLine("\n\tCARGA DE DATOS DE LOS EMPLEADOS");
for (int i = 0; i < empleados.Length; i++)
{
    Console.WriteLine($"\n\t\tCargando los datos del empleado {i+1}");
    empleados[i] = new Empleado();  /* creacion del objeto empleado */
    bool ok = false;    /* variable booleana para confirmar algunas cargas */
    string entrada;     /* variable que es usada como entrada del taclado */

    // Ingreso el nombre del empleado
    do
    {
        Console.Write("\n\tNombre:\t");
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
        Console.Write("\n\tApellido:\t");
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
        Console.Write("\n\tFecha de nacimiento (dd/mm/yyyy):\t");
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
        Console.Write("\n\tFecha de ingreso (dd/mm/yyyy):\t");
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
        Console.Write("\n\t---Estado civil---\n\tSoltero/a = S\n\tCasado/a = C\n\tDivorciado/a = D\n\tViudo/a = V\n\tEstado:\t");
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