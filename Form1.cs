namespace Ventas
{
    public partial class Form1 : Form
    {
        int contador = 1;
        public Form1()
        {
            InitializeComponent();
        }
        clsValidar obj = new clsValidar();
        private void btmmPagar_Click(object sender, EventArgs e)
        {
            contador++;
            txtFolio.Text = contador.ToString();
            txtCantList.Text = "";
            txtArtNomList.Text = "";
            txtArtNom.Text = "";
            txtDescpList.Text = "";
            txtArtDescrp.Text = "";
            txtPrecioList.Text = "";
            txtPrecio.Text = "";
            txtSubtotal.Text = "0";
            txtIVA.Text = "";
            txtTotal.Text = "";
        }
        public void Calcular(KeyPressEventArgs e)
        {
            txtCantList.Text += numericUpDown1.Value + "\r\n";
            txtArtNomList.Text += txtArtNom.Text + "\r\n";
            txtDescpList.Text += txtArtDescrp.Text + "\r\n";
            txtPrecioList.Text += txtPrecio.Text + "\r\n";
            txtSubtotal.Text = (Convert.ToDouble(txtSubtotal.Text) + (Convert.ToDouble(txtPrecio.Text) * Convert.ToDouble(numericUpDown1.Value))).ToString();
            txtIVA.Text = (Convert.ToDouble(txtSubtotal.Text) * 0.16).ToString();

            if (Convert.ToDouble(txtSubtotal.Text) >= 1500)
            {
                lblDescuento.Text = "Su descuento es de " + (Convert.ToDouble(txtSubtotal.Text) / 15).ToString();
                txtTotal.Text = ((Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtIVA.Text)) - (Convert.ToDouble(txtSubtotal.Text) / 15)).ToString();
            }
            else
            {
                lblDescuento.Text = "Su descuento es de " + (Convert.ToDouble(txtSubtotal.Text) / 10).ToString();
                txtTotal.Text = ((Convert.ToDouble(txtSubtotal.Text) + Convert.ToDouble(txtIVA.Text)) - (Convert.ToDouble(txtSubtotal.Text) / 10)).ToString();
            }
            numericUpDown1.Focus();
            numericUpDown1.Value = 0;
            txtArtNom.Text = "";
            txtArtDescrp.Text = "";
            txtPrecio.Text = "";

        }
        private void txtArtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txtArtDescrp.Text != string.Empty && txtArtNom.Text != string.Empty && txtPrecio.Text != string.Empty)
                {
                    Calcular(e);

                }
            }

        }

        private void txtArtDescrp_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((Keys)e.KeyChar == Keys.Enter)
            {
                if (txtArtDescrp.Text != string.Empty && txtArtNom.Text != string.Empty && txtPrecio.Text != string.Empty)
                {

                    Calcular(e);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFolio.Text = "1";
            txtSubtotal.Text = "0";
        }

        private void txtNumEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (obj.Validar_Numeros(e))
            {
                e.Handled = false;
                if (txtNumEmpleado.Text == "123")
                {
                    txtNombreEmpleado.Text = "Zuriel Rodriguez";
                }
                else if (txtNumEmpleado.Text == "1999")
                {
                    txtNombreEmpleado.Text = "Julieta Guerrero";
                }
                else
                {
                    txtNombreEmpleado.Text = "";
                }

            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (obj.Validar_Numeros(e))
            {
                e.Handled = false;
                if ((Keys)e.KeyChar == Keys.Enter)
                {
                    if (txtArtDescrp.Text != string.Empty && txtArtNom.Text != string.Empty && txtPrecio.Text != string.Empty)
                    {
                        Calcular(e);

                    }
                }
            }
            
        }
    }
}