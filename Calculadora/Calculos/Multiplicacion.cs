using System;


namespace Calculos
{
    public class Multiplicacion
    {

        public int Multiplicando { get; set; }
        public int Multiplicador { get; set; }

        public Multiplicacion(int multiplicando, int multiplicador)
        {
            Multiplicando = multiplicando;
            Multiplicador = Multiplicador;
        }

        public Multiplicacion()
        {
            Multiplicando = 0;
            Multiplicador = 0;
        }

        public void multiplicacion()
        {
            string strMultiplicando = Convert.ToString(Multiplicando);
            string strMultiplicador = Convert.ToString(Multiplicador);

        }

        private int multiplicar(int multiplicando, int multiplicador)
        {
            return 1;
        }
    }
}