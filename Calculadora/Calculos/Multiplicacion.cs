using System;
using System.ComponentModel;


namespace Calculos
{
    public class Multiplicacion
    {

        public int Multiplicando { get; set; }
        public int Multiplicador { get; set; }

        public Multiplicacion(int multiplicando, int multiplicador)
        {
            Multiplicando = multiplicando;
            Multiplicador = multiplicador;
        }

        public Multiplicacion()
        {
            Multiplicando = 0;
            Multiplicador = 0;
        }

        /// <summary>
        /// Mutiplica dos numeros
        /// </summary>
        public void multiplicacion()
        {
            string strMultiplicando = Convert.ToString(Multiplicando);
            string strMultiplicador = Convert.ToString(Multiplicador);
            for (int i = strMultiplicador.Length - 1; i >= 0; i--)
            {
                for (int j = strMultiplicando.Length - 1; j >= 0; j--)
                {
                    string[] resultado = multiplicar(int.Parse(strMultiplicando[j].ToString()), int.Parse(strMultiplicador[i].ToString()));
                    if (resultado == null)
                    {
                        string s = string.Empty;
                    }
                }
            }
        }

        /// <summary>
        /// Comprueba el valor a retornar de la multiplicacion individual
        /// </summary>
        /// <param name="multiplicando">Multiplicando de la operacion</param>
        /// <param name="multiplicador">Multiplicador de la operacion</param>
        /// <returns>Retorna la cantidad de terminso que genero la division</returns>
        private string[] multiplicar(int multiplicando, int multiplicador)
        {
            string res = string.Empty;
            try
            {
                res = Convert.ToString(multiplicando * multiplicador);
            }
            catch (InvalidCastException ex)
            {
                throw ex;
            }
            switch (res.Length)
            {
                case 1:
                    return new string[] { res.Substring(0, 1) };
                case 2:
                    return new string[] { res.Substring(1, 1), res.Substring(0, 1) };
                default:
                    return null;
            }
        }
    }
}