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

        public string Nombre{
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido{
            get { return apellido; }
            set { apellido = value; }
        }
        public char estadoCivil{
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }
        public DateTime FechaNacimiento{
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public DateTime Fechaingreso{
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        public float SueldoBasico{
            get { return sueldoBasico; }
            set { sueldoBasico = value; }
        }

        public Cargos CargoEmpleado{
            get { return cargoEmpleado; }
            set { cargoEmpleado = value; }
        }
    }
}