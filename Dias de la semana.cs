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
    public partial class Dias_de_la_semana : Form
    {
        public Dias_de_la_semana()
        {
            InitializeComponent();
        }

        private void btmHacer_Click(object sender, EventArgs e)
        {
            ClsNumeroLetra obj = new ClsNumeroLetra();
            if (txtDia.Text == "1")
            {
                txtNombre.Text = "Lunes";
                txtLeyenda.Text = "Hoy es el dia de Maria";
                errorProvider1.SetError(txtDia, "");
                LabelNumero.Text = obj.ConvertirCadena(Convert.ToDouble(txtDia.Text));
            }
            else if (txtDia.Text == "2")
            {
                txtNombre.Text = "Martes";
                txtLeyenda.Text = "Hoy esta cara la gasolina";
                errorProvider1.SetError(txtDia, "");
                LabelNumero.Text = obj.ConvertirCadena(Convert.ToDouble(txtDia.Text));

            }
            else if (txtDia.Text == "3")
            {
                txtNombre.Text = "Miercoles";
                txtLeyenda.Text = "Miercoles de frescura en Walmart";
                errorProvider1.SetError(txtDia, "");
                LabelNumero.Text = obj.ConvertirCadena(Convert.ToDouble(txtDia.Text));


            }
            else if (txtDia.Text == "4")
            {
                txtNombre.Text = "Jueves";
                txtLeyenda.Text = "Hoy no hay clases";
                errorProvider1.SetError(txtDia, "");
                LabelNumero.Text = obj.ConvertirCadena(Convert.ToDouble(txtDia.Text));


            }
            else if (txtDia.Text == "5")
            {
                txtNombre.Text = "Viernes";
                txtLeyenda.Text = "Hoy juega el cruz azul";
                errorProvider1.SetError(txtDia, "");
                LabelNumero.Text = obj.ConvertirCadena(Convert.ToDouble(txtDia.Text));

            }
            else if (txtDia.Text == "6")
            {
                txtNombre.Text = "Sabado";
                txtLeyenda.Text = "Hoy estan a 2x1 las donas en Ley";
                errorProvider1.SetError(txtDia, "");
                LabelNumero.Text = obj.ConvertirCadena(Convert.ToDouble(txtDia.Text));

            }
            else if (txtDia.Text == "7")
            {
                txtNombre.Text = "Domingo";
                txtLeyenda.Text = "Hoy hay servicio en la Iglesia";
                errorProvider1.SetError(txtDia, "");
                LabelNumero.Text = obj.ConvertirCadena(Convert.ToDouble(txtDia.Text));


            }
            else if (Convert.ToInt32(txtDia.Text) > 7 || Convert.ToInt32(txtDia.Text) < 1)
            {
                MessageBox.Show("Dia desconocido");

            }
        }

        private void btmHacer_KeyPress(object sender, KeyPressEventArgs e)
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
