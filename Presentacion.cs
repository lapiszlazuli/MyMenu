using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;

namespace My_Menu
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
            timer1.Start();//


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value >= 100)
            {
                Bienvenida forma = new Bienvenida();
                forma.Show();
                this.Hide();
                timer1.Stop();

            }
        }
    }
}
