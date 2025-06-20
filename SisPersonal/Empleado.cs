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
        public void AsignarNombre(string nuevoNombre) => nombre = nuevoNombre;
        public void AsignarApellido(string nuevoApellido) => apellido = nuevoApellido;
        public void AsignarEC(char estado) => estadoCivil = estado;
        public void AsignarSueldo(float sueldo){
            if(sueldo > 0){
                sueldoBasico = sueldo;       
            }else{
                Console.WriteLine("\n\t\t---Error no es posible ingresar un valor negativo");
            }
        }
        public void AsignarFechaNacimiento(DateTime fecha) => fechaNacimiento = fecha;
        public void AsignarFechaIngreso(DateTime fecha) => fechaIngreso = fecha;
        public void AsignarCargo(Cargos nuevoCargo) => cargoEmpleado = nuevoCargo;
    }
}