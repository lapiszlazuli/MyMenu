

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public void CambiardeVentana()
        {
            foreach (Form Forma in MdiChildren)
            {
                Forma.Close();

            }
        }
        private void gasolinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiardeVentana();
            Gasolina obj = new Gasolina();
            obj.MdiParent = this;
            obj.Show();

        }

        private void diasDeLaSemanaIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiardeVentana();
            Dias_de_la_semana obj = new Dias_de_la_semana();
            obj.MdiParent = this;
            obj.Show();
        }

        private void numerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiardeVentana();
            Numeros obj = new Numeros();
            obj.MdiParent = this;
            obj.Show();
        }

        private void parImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiardeVentana();
            Par_Impar obj = new Par_Impar();
            obj.MdiParent = this;
            obj.Show();
        }

        private void diasDeLaSemanaSwitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiardeVentana();
            Dias_de_la_semana__Switch_ obj = new Dias_de_la_semana__Switch_();
            obj.MdiParent = this;
            obj.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void claseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiardeVentana();
            Clase obj = new Clase();
            obj.MdiParent = this;
            obj.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiardeVentana();
            Calculadora obj = new Calculadora();
            obj.MdiParent = this;
            obj.Show();


        }

        private void formulaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiardeVentana();
            Formula_General obj = new Formula_General();
            obj.MdiParent = this;
            obj.Show();
        }

        private void doWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiardeVentana();
            Do_While obj = new Do_While();
            obj.MdiParent = this;
            obj.Show();
        }

        private void superToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
