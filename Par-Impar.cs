using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Menu
{
    public partial class Par_Impar : Form
    {
        public Par_Impar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        ClsNumeroLetra obj = new ClsNumeroLetra();
        private void btmHacer_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(txtNumero.Text);
            if (Numero % 2 == 0)
            {
                MessageBox.Show("El Numero introducido (" + Numero + ") es Par");
            }
            else
            {
                MessageBox.Show("El Numero introducido (" + Numero + ") es Impar");
            }
            if (comboBox1.SelectedItem.ToString() == "Par")
            {
                if (Numero == 2 || Numero < 2)
                {
                    txtNumeros.Text = "2" + " " + obj.ConvertirCadena(2);
                }
                else
                {
                    txtNumeros.Text = "2" + " " + obj.ConvertirCadena(2);
                    for (int i = 3; i <= Numero; i++)
                    {
                        if (i % 2 == 0)
                        {
                            txtNumeros.Text += "," + i + " " + obj.ConvertirCadena(i);
                        }
                    }
                }

            }
            if (comboBox1.SelectedItem.ToString() == "Impar")
            {
                if (Numero == 2 || Numero < 2)
                {
                    txtNumeros.Text = "1" + " " + obj.ConvertirCadena(1);
                }
                else
                {
                    txtNumeros.Text = "1" + " " + obj.ConvertirCadena(1);
                    for (int i = 2; i <= Numero; i++)
                    {
                        if (i % 2 != 0)
                        {
                            txtNumeros.Text += "," + i + " " + obj.ConvertirCadena(i);
                        }
                    }
                }

            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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
