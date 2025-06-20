using System;

namespace EspacioEmpleado
{
    public enum Cargos{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Empleado{
        private string nombre, apellido;
        private DateTime fechaNacimiento, fechaIngreso;
        private char estadoCivil;
        private float sueldoBasico;
        private Cargos cargoEmpleado;

        public string Nombre => nombre;
        public string Apellido => apellido;
        public char EstadoCivil => estadoCivil;
        public DateTime FechaNacimiento => fechaNacimiento;
        public DateTime FechaIngreso => fechaIngreso;
        public float SueldoBasico => sueldoBasico;
        public Cargos CargoEmpleado => cargoEmpleado;

    }
}