using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Menu
{
    internal class ClsOperaciones
    {
        public ClsOperaciones()
        {

        }
        public double Suma(double N1, double N2)
        {
            return (N1+ N2);
        }
        public double Resta(double N1, double N2)
        {
            return (N1 - N2);
        }
        public double Multiplicacion(double N1, double N2)
        {
            return (N1 * N2);
        }
        public double Division(double N1, double N2)
        {
            return (N1 / N2);
        }
        public string Borrar (string Texto)
        {
            string Resultado = "";
            for (int i = 0; i < Texto.Length-1; i++) 
            {
                Resultado+= Texto[i];
            }
            return Resultado;
        }
    }
}
