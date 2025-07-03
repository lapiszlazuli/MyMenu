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
    public partial class Numeros : Form
    {
        public Numeros()
        {
            InitializeComponent();
        }

        private void btmHacer_Click(object sender, EventArgs e)
        {
            try
            {
                int Num = 2;
                txtNumeros.Text = "1";
                while (Num <= Convert.ToInt32(txtNumero.Text))
                {
                    txtNumeros.Text += "," + Num.ToString();
                    Num++;

                }
                ClsNumeroLetra obj = new ClsNumeroLetra();
                lblNum.Text = obj.ConvertirCadena(txtNumero.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Eror", ex.Message);
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
