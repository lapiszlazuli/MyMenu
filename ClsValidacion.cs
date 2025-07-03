using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Menu
{
    internal class ClsValidacion
    {
        public bool Validar_Letras (KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                return false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                return false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Validar_Numeros (KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
