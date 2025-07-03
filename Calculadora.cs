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
    public partial class Calculadora : Form
    {
        double N1 = 0;
        double N2 = 0;
        int Operacion = 0;
        double Resultado = 0;
        string Historial = "";
        Boolean Final = false;
        Boolean Igual = true;
        ClsNumeroLetra obj1 = new ClsNumeroLetra();
        public Calculadora()
        {
            InitializeComponent();

        }
        private void btmm1_Click(object sender, EventArgs e)
        {
            if (Final)
            {
                txtPantalla.Text = "";
                txtPantalla.Text += "1";
            }
            else
            {
                txtPantalla.Text += "1";
            }
            Final = false;

        }

        private void btmm2_Click(object sender, EventArgs e)
        {
            if (Final)
            {
                txtPantalla.Text = "";
                txtPantalla.Text += "2";
            }
            else
            {
                txtPantalla.Text += "2";
            }
            Final = false;

        }

        private void btmm3_Click(object sender, EventArgs e)
        {
            if (Final)
            {
                txtPantalla.Text = "";
                txtPantalla.Text += "3";
            }
            else
            {
                txtPantalla.Text += "3";
            }
            Final = false;

        }

        private void btmm4_Click(object sender, EventArgs e)
        {
            if (Final)
            {
                txtPantalla.Text = "";
                txtPantalla.Text += "4";
            }
            else
            {
                txtPantalla.Text += "4";
            }
            Final = false;
        }

        private void btmm5_Click(object sender, EventArgs e)
        {
            if (Final)
            {
                txtPantalla.Text = "";
                txtPantalla.Text += "5";
            }
            else
            {
                txtPantalla.Text += "5";
            }
            Final = false;

        }

        private void btmm6_Click(object sender, EventArgs e)
        {
            if (Final)
            {
                txtPantalla.Text = "";
                txtPantalla.Text += "6";
            }
            else
            {
                txtPantalla.Text += "6";
            }
            Final = false;

        }

        private void btmm7_Click(object sender, EventArgs e)
        {
            if (Final)
            {
                txtPantalla.Text = "";
                txtPantalla.Text += "7";
            }
            else
            {
                txtPantalla.Text += "7";
            }
            Final = false;

        }

        private void btmm8_Click(object sender, EventArgs e)
        {
            if (Final)
            {
                txtPantalla.Text = "";
                txtPantalla.Text += "8";
            }
            else
            {
                txtPantalla.Text += "8";
            }
            Final = false;

        }

        private void btmm9_Click(object sender, EventArgs e)
        {
            if (Final)
            {
                txtPantalla.Text = "";
                txtPantalla.Text += "9";
            }
            else
            {
                txtPantalla.Text += "9";
            }
            Final = false;

        }

        //Para las operaciones
        //0 = Suma
        //1 = Resta
        //2 = Multiplicación
        //3 = Division
        private void btmmSuma_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != string.Empty)
            {
                if (Final)
                {
                    this.btmmIgual_Click(sender, e);
                    N1 = Resultado;

                }
                N1 = Convert.ToDouble(txtPantalla.Text);
                Operacion = 0;
                txtPantalla.Text = "";
                Final = true;
            }

        }
        private void btmmResta_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != string.Empty)
            {
                if (Final)
                {
                    this.btmmIgual_Click(sender, e);
                    N1 = Resultado;

                }
                N1 = Convert.ToDouble(txtPantalla.Text);
                Operacion = 1;
                txtPantalla.Text = "";
                Final = true;
            }

        }

        private void btmmMultiplicacion_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != string.Empty)
            {
                if (Final)
                {
                    this.btmmIgual_Click(sender, e);
                    N1 = Resultado;

                }
                N1 = Convert.ToDouble(txtPantalla.Text);
                Operacion = 2;
                txtPantalla.Text = "";
                Final = true;
            }

        }

        private void btmmDivision_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != string.Empty)
            {
                if (Final)
                {
                    this.btmmIgual_Click(sender, e);
                    N1 = Resultado;

                }
                N1 = Convert.ToDouble(txtPantalla.Text);
                Operacion = 3;
                txtPantalla.Text = "";
                Final = true;
            }

        }

        private void btmmBorrar_Click(object sender, EventArgs e)
        {
            string Texto = "";
            for (int i = 0; i < txtPantalla.Text.Length - 1; i++)
            {
                Texto += txtPantalla.Text[i].ToString();
            }
            txtPantalla.Text = Texto;
        }

        private void btmmPunto_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text != string.Empty)
            {
                Final = false;
                txtPantalla.Text += ".";
            }

        }

        private void btmmIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text != string.Empty)
                {
                    //if (N2==0)
                    //{
                    //    MessageBox.Show("si");
                    //}

                    N2 = Convert.ToDouble(txtPantalla.Text);
                    RchtxtHistorial.Text += N1.ToString() + "" + obj1.ConvertirCadena(N1);
                    ClsOperaciones obj = new ClsOperaciones();
                    switch (Operacion)
                    {
                        case 0:
                            Resultado = obj.Suma(N1, N2);
                            RchtxtHistorial.Text += " + ";
                            break;
                        case 1:
                            Resultado = obj.Resta(N1, N2);
                            RchtxtHistorial.Text += " - ";
                            break;
                        case 2:
                            Resultado = obj.Multiplicacion(N1, N2);
                            RchtxtHistorial.Text += " x ";
                            break;
                        case 3:
                            Resultado = obj.Division(N1, N2);
                            RchtxtHistorial.Text += " / ";
                            break;
                    }
                    RchtxtHistorial.Text += N2.ToString() + "" + obj1.ConvertirCadena(N2) + " = " + Resultado.ToString() + "" + obj1.ConvertirCadena(Convert.ToDouble(Resultado)) + "\r";
                    txtPantalla.Text = Resultado.ToString();
                    N1 = N2;
                    N2 = 0;

                }

            }
            catch (Exception)
            {

                throw;
            }
            
            

        }

        private void btmm0_Click(object sender, EventArgs e)
        {
            if (Final)
            {
                txtPantalla.Text = "";
                txtPantalla.Text += "0";
            }
            //else
            //{
            //    txtPantalla.Text += "0";
            //}

        }

        private void btmmCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
        }


    }
}
