using System;
using System.Runtime.CompilerServices;
using Internal;

namespace EspacioEmpleado
{
    // enum con los distintos cargos de un empleado
    public enum Cargos{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    // clase para el obejeto empleado
    public class Empleado{
        // campos del objeto
        private string nombre, apellido;
        private DateTime fechaNacimiento, fechaIngreso;
        private char estadoCivil;
        private float sueldoBasico;
        private Cargos cargoEmpleado;

        //propiedades para de solo lectura para los campos
        public string Nombre => nombre;
        public string Apellido => apellido;
        public char EstadoCivil => estadoCivil;
        public DateTime FechaNacimiento => fechaNacimiento;
        public DateTime FechaIngreso => fechaIngreso;
        public float SueldoBasico => sueldoBasico;
        public Cargos CargoEmpleado => cargoEmpleado;

        // metodos para cargar los datos
        public bool AsignarNombre(string nuevoNombre) {
            if (!string.IsNullOrEmpty(nuevoNombre))
            {
                nombre = nuevoNombre;
                return true;
            }else
            {
                Console.WriteLine("Error no es posible asignar un valor vacio");
                return false;
            }
        }
        public bool AsignarApellido(string nuevoApellido){
            if (!string.IsNullOrEmpty(nuevoApellido))
            {
                apellido = nuevoApellido;
                return true;
            }else
            {
                Console.WriteLine("Error no es posible asignar un valor vacio");
                return false;
            }
        }
        public bool AsignarEC(char estado) {
            estado = char.ToUpper(estado);
            if (estado == 'S' || estado == 'C' || estado == 'D' || estado == 'V'){
                estadoCivil = estado;
                return true;
            }else{
                Console.WriteLine("Estado invalido");
                return false;
            }
        }
        public bool AsignarSueldo(float sueldo){
            if(sueldo > 0){
                sueldoBasico = sueldo;       
                return true;
            }else{
                Console.WriteLine("\n\t\t---Error no es posible ingresar un valor negativo");
                return false;
            }
        }
        public bool AsignarFechaNacimiento(DateTime fecha){
            if (DateTime.Today.AddYears(-18) >= fecha)
            {
                fechaNacimiento = fecha;
                return true;
            }else{
                Console.WriteLine("\n\t\t---Error no es posible ingresar menores");
                return false;
            }
        }
        public bool AsignarFechaIngreso(DateTime fecha){
            if (fechaNacimiento > fecha)
            {
                Console.WriteLine("\n\t\t---Error el ingreso no puede ser antes del nacimiento");
                return false;
            }else if(DateTime.Today < fecha)
                {
                Console.WriteLine("\n\t\t---Error no es posible ingresar una fecha futura");
                return false;
            }else{
                fechaIngreso = fecha;
                return true;
            }
        }
        public bool AsignarCargo(Cargos nuevoCargo) => cargoEmpleado = nuevoCargo;

        // metodos del trabajo practico


    }
}