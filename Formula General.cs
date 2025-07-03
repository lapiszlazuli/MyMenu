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
    public partial class Formula_General : Form
    {
        public Formula_General()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txtA.Text != string.Empty && txtC.Text != string.Empty)
                {
                   
                    if (Convert.ToDouble(txtA.Text) < Convert.ToDouble(txtB.Text))
                    {
                        errorProvider1.SetError(txtB, "El Valor de B debe ser el doble del valor de A");
                    }
                    if (Convert.ToDouble(txtA.Text) < 4)
                    {
                        errorProvider1.SetError(txtA, "El Valor de A debe mayor a 4");
                    }
                    else
                    {
                        Calcular();
                    }
                }
            }
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txtB.Text != string.Empty && txtC.Text != string.Empty)
                {
                    
                    if (Convert.ToDouble(txtA.Text) < Convert.ToDouble(txtB.Text))
                    {
                        errorProvider1.SetError(txtB, "El Valor de B debe ser el doble del valor de A");
                    }
                    if (Convert.ToDouble(txtA.Text)<4)
                    {
                        errorProvider1.SetError(txtA,"El Valor de A debe mayor a 4");
                    }
                    else
                    {
                        Calcular();
                    }
                }
            }
        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txtB.Text != string.Empty && txtA.Text != string.Empty)
                {
                    
                    if (Convert.ToDouble(txtA.Text) < Convert.ToDouble(txtB.Text))
                    {
                        errorProvider1.SetError(txtB, "El Valor de B debe ser el doble del valor de A");
                    }
                    if (Convert.ToDouble(txtA.Text) < 4)
                    {
                        errorProvider1.SetError(txtA, "El Valor de A debe mayor a 4");
                    }
                    else
                    {
                        Calcular();
                    }
                }
            }
        }
        public void Calcular()
        {
            try
            {
                double A = 0, B = 0, C = 0, R1 = 0, R2 = 0;
                A = Convert.ToDouble(txtA.Text);
                B = Convert.ToDouble(txtB.Text);
                C = Convert.ToDouble(txtC.Text);
                R1 = ((-1 * B) + Math.Sqrt((Math.Pow(B, 2) - (4 * A * C)))) / (2 * A);
                R2 = ((-1 * B) - Math.Sqrt((Math.Pow(B, 2) - (4 * A * C)))) / (2 * A);
                txtResultado1.Text = R1.ToString();
                txtResultado2.Text = R2.ToString();
                ClsNumeroLetra obj = new ClsNumeroLetra();
                lblx1.Text = obj.ConvertirCadena(R1);
                lblx2.Text = obj.ConvertirCadena(R2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }
    }
}

