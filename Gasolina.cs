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
    public partial class Gasolina : Form
    {
        public Gasolina()
        {
            InitializeComponent();
        }

        private void btmHacer_Click(object sender, EventArgs e)
        {
            try
            {
                ClsNumeroLetra obj = new ClsNumeroLetra();
                if (radioButton1.Checked)
                {
                    txtResul.Text = "" + Convert.ToInt32(txtLitros.Text) * 1.8;
                    LabelLetras.Text = obj.ConvertirCadena(Convert.ToDouble(txtResul.Text));
                    txtResul.Text = "$" + txtResul.Text;
                }
                if (radioButton2.Checked)
                {
                    txtResul.Text = "" + Convert.ToInt32(txtLitros.Text) * 17;
                    LabelLetras.Text = obj.ConvertirCadena(Convert.ToDouble(txtResul.Text));
                    txtResul.Text = "$" + txtResul.Text;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrio un error", ex.Message);
            }
            
            
        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLitros_KeyPress(object sender, KeyPressEventArgs e)
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
