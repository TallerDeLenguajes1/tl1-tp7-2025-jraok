using System;
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
        // constante para el sueldo
        private const float SUELDO_INICIAL = 100000f;
        // campos del objeto
        private string nombre, apellido;
        private DateTime fechaNacimiento, fechaIngreso;
        private char estadoCivil;
        private float sueldoBasico = SUELDO_INICIAL;
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
            }else{
                return false;
            }
        }
        public bool AsignarEC(char estado) {
            estado = char.ToUpper(estado);
            if (estado == 'S' || estado == 'C' || estado == 'D' || estado == 'V'){
                estadoCivil = estado;
                return true;
            }else{
                return false;
            }
        }
        public bool AsignarNuevoSueldo(float sueldo){
            if(sueldo > 0){
                sueldoBasico = sueldo;       
                return true;
            }else{
                return false;
            }
        }
        public bool AsignarFechaNacimiento(DateTime fecha){
            if (DateTime.Today.AddYears(-18) >= fecha)
            {
                fechaNacimiento = fecha;
                return true;
            }else{
                return false;
            }
        }
        public bool AsignarFechaIngreso(DateTime fecha){
            if (fechaNacimiento > fecha)
            {
                return false;
            }else if(DateTime.Today < fecha)
                {
                return false;
            }else{
                fechaIngreso = fecha;
                return true;
            }
        }
        public void AsignarCargo(Cargos nuevoCargo) => cargoEmpleado = nuevoCargo;

        // metodos del trabajo practico

        // metodo para calcular la edad
        public int CalcularEdad(){
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            return DateTime.Today < fechaNacimiento.AddYears(edad) ? --edad : edad;
        }

        // metodo para calcular la antiguedad
        public int CalcularAntiguedad(){
            int antiguedad = DateTime.Today.Year - fechaIngreso.Year;
            return DateTime.Today < fechaIngreso.AddYears(antiguedad) ? (--antiguedad) : antiguedad;
        }

        // metodo para calcular lo que falta para jubilarse
        public int Jubilacion(){
            int jubilo = 65 - CalcularEdad();
            return jubilo > 0 ? jubilo : 0;
        }
         // metodo para calcular el sueldo
        public float CalcularSueldo(){
            float porcentaje = 1;
            int antiguedad = CalcularAntiguedad();

            if (antiguedad > 19)
            {
                porcentaje = 1.25f;
            }else if(antiguedad > 0){
                porcentaje += antiguedad/100f;
            }

            if (cargoEmpleado == Cargos.Ingeniero || cargoEmpleado == Cargos.Especialista) 
                porcentaje*=1.5f; 

            return estadoCivil == 'C' ? (sueldoBasico * porcentaje + 150000) : sueldoBasico * porcentaje;
        }

    }
}