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
        public void AsignarNombre(string nuevoNombre) {
            if (!string.IsNullOrEmpty(nuevoNombre))
            {
                nombre = nuevoNombre;
            }else
            {
                Console.WriteLine("Error no es posible asignar un valor vacio");
            }
        }
        public void AsignarApellido(string nuevoApellido){
            if (!string.IsNullOrEmpty(nuevoApellido))
            {
                apellido = nuevoApellido;
            }else
            {
                Console.WriteLine("Error no es posible asignar un valor vacio");
            }
        }
        public void AsignarEC(char estado) {
            estado = char.ToUpper(estado);
            if (estado == 'S' || estado == 'C' || estado == 'D' || estado == 'V'){
                estadoCivil = estado;
            }else{
                Console.WriteLine("Estado invalido");
            }
        }
        public void AsignarSueldo(float sueldo){
            if(sueldo > 0){
                sueldoBasico = sueldo;       
            }else{
                Console.WriteLine("\n\t\t---Error no es posible ingresar un valor negativo");
            }
        }
        public void AsignarFechaNacimiento(DateTime fecha){
            if (DateTime.Today.AddYears(-18) >= fecha)
            {
                fechaNacimiento = fecha;
            }else{
                Console.WriteLine("\n\t\t---Error no es posible ingresar menores");
            }
        }
        public void AsignarFechaIngreso(DateTime fecha){
            if (fechaNacimiento > fecha)
            {
                Console.WriteLine("\n\t\t---Error el ingreso no puede ser antes del nacimiento");
            }else if(DateTime.Today < fecha)
                {
                Console.WriteLine("\n\t\t---Error no es posible ingresar una fecha futura");
            }else{
                fechaIngreso = fecha;
            }
        }
        public void AsignarCargo(Cargos nuevoCargo) => cargoEmpleado = nuevoCargo;

        // metodos del trabajo practico


    }
}