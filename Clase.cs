using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My_Menu
{
    public partial class Clase : Form
    {
        public Clase()
        {
            InitializeComponent();
        }
        ClsNumeroLetra OBJ = new ClsNumeroLetra();
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            String Resultado;

            if (numericUpDown1.Text != string.Empty)
            {
                Resultado = OBJ.ConvertirCadena(Convert.ToDouble(numericUpDown1.Text) + 1);
                if (Resultado != "")
                {
                    textBox1.Text = Resultado;
                }
                else
                {
                    MessageBox.Show("Introduzca un valor correcto", "Error");

                }
            }
        }

        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e)
        {

            String Resultado;

            if (numericUpDown1.Text != string.Empty)
            {
                Resultado = OBJ.ConvertirCadena(Convert.ToDouble(numericUpDown1.Text));
                if (Resultado != "")
                {
                    textBox1.Text = Resultado;
                }
                else
                {
                    MessageBox.Show("Introduzca un valor correcto", "Error");

                }
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidacion obj = new ClsValidacion();
            if (obj.Validar_Numeros(e))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
