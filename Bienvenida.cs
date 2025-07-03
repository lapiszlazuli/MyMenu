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
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();

        }
        int contador = 0;
        private void Bienvenida_Load(object sender, EventArgs e)
        {

        }

        private void btmIniciar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Ingresa un Usuario", "Error");
                errorProvider1.SetError(txtUsuario, "Ingresa un usuario");

            }
            else
            {
                if (txtContraseña.Text == string.Empty)
                {
                    MessageBox.Show("Ingresa una Contraseña", "Erorr");
                    errorProvider1.SetError(txtContraseña, "Ingresa una Contraseña");
                }
                else
                {
                    if (contador > 2)
                    {
                        MessageBox.Show("Numero de intetos excedido", "Error");
                        MessageBox.Show("Se va a cerrar la aplicacion", "Aviso", MessageBoxButtons.OK);
                        Application.Exit();
                    }
                    else
                    {
                        if (txtUsuario.Text == "Usuario")
                        {
                            if (txtContraseña.Text == "123")
                            {
                                Menu obj = new Menu();
                                obj.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta", "Error");
                                contador++;
                                txtUsuario.Text = "";
                                txtContraseña.Text = "";
                                txtUsuario.Focus();
                                errorProvider1.SetError(txtContraseña, "Contraseña incorrecta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario incorrecto", "Error");
                            contador++;
                            txtUsuario.Text = "";
                            txtContraseña.Text = "";
                            txtUsuario.Focus();
                            errorProvider1.SetError(txtUsuario, "Usuario Incorrecto");
                        }
                    }
                }
            }



        }

        private void txtContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtContraseña.Text != string.Empty)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (contador > 2)
                    {
                        MessageBox.Show("Numero de intetos excedido", "Error");
                        MessageBox.Show("Se va a cerrar la aplicacion ", "Aviso", MessageBoxButtons.OK);
                        Application.Exit();
                    }
                    else
                    {
                        if (txtUsuario.Text == "Usuario")
                        {
                            if (txtContraseña.Text == "123")
                            {
                                Menu obj = new Menu();
                                obj.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta", "Error");
                                contador++;
                                txtUsuario.Text = "";
                                txtContraseña.Text = "";
                                txtUsuario.Focus();
                                errorProvider1.SetError(txtContraseña, "Contraseña incorrecta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario incorrecto", "Error");
                            contador++;
                            txtUsuario.Text = "";
                            txtContraseña.Text = "";
                            txtUsuario.Focus();
                            errorProvider1.SetError(txtUsuario, "Usuario Incorrecto");
                        }
                    }

                }
            }

        }

    }
}
