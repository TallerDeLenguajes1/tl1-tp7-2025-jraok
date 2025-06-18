using EspacioCalculadora;

// variables para el programa
double numero = 0, opcion = 0;
string operacion;
Calculadora calculador = new Calculadora();

// estructura loggica para el programa
do{
    // menu de opciones
    Console.WriteLine("\n\t\t----Taller de lenguajes 1----");
    Console.WriteLine("\tMenu de opciones");
    Console.WriteLine("\t1. Sumar");
    Console.WriteLine("\t2. Restar");
    Console.WriteLine("\t3. Multiplicar");
    Console.WriteLine("\t4. Dividir");
    Console.WriteLine("\t5. Limpiar");
    Console.Write("\n\tElija una opcion (ENTER PARA CANCELAR):\t");
    operacion = Console.ReadLine();     /* lectura de la opcion elegida del menu */

    if(string.IsNullOrEmpty(operacion))break; /* verificacion de qque si se cancelo la operacion */

    // verificacion que no se ingrese un string u opcion invalida
    if(!double.TryParse(operacion, out opcion) || (opcion < 1 || opcion > 5)){
        Console.WriteLine("\t\t---ERROR OPCION NO VALIDA, REINGRESE---");
        continue;   /* salto al proximo ciclo en caso de que la entrada sea invalida */
    }

    
    do{
        Console.Write("\n\tDesea continuar? (Si = 1 | No = 2):\t");
        if(!double.TryParse(Console.ReadLine(), out opcion) || (opcion != 1 && opcion != 2)){
           Console.WriteLine("\t\t---OPCION NO VALIDA, REINGRESE---");
           continue;
        }
    }while(opcion != 1 && opcion != 2);

    Console.WriteLine(new string('-', 50)); // separador visual
}while(opcion == 1);