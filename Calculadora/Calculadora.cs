namespace EspacioCalculadora
{
    public class Calculadora
    {
        private float dato;
        public float Dato { get { return dato; } }
        public void Sumar(float numero)
        {
            Dato += numero;
        }

        public void Restar(float numero)
        {
            Dato -= numero;
        }

        public void Multiplicar(float numero)
        {
            Dato *= numero;
        }

        public void Dividir(float numero)
        {
            if (numero != 0)
            {
                Dato /= numero;
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