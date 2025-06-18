namespace EspacioCalculadora
{
    public class Calculadora
    {
        private float dato;
        public float Dato { get { return dato; } }
        public void Sumar(float numero)
        {
            dato += numero;
        }

        public void Restar(float numero)
        {
            dato -= numero;
        }

        public void Multiplicar(float numero)
        {
            dato *= numero;
        }

        public void Dividir(float numero)
        {
            if (numero != 0)
            {
                dato /= numero;
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }
        }
        public void Limpiar()
        {
            dato = 0;
        }
    }
}