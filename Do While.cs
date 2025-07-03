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
    public partial class Do_While : Form
    {
        public Do_While()
        {
            InitializeComponent();
        }

        private void btmWhile_Click(object sender, EventArgs e)
        {
            int renglon = 1;
            lbDatos.Items.Clear();
            while (renglon <= 10)
            {
                lbDatos.Items.Add(renglon.ToString() + " Queridos Profesores");
                renglon++;
            }
        }

        private void btmDoWhile_Click(object sender, EventArgs e)
        {
            int renglon = 1;
            lbDatos.Items.Clear();
            do
            {
                lbDatos.Items.Add(renglon.ToString() + " Queridos Profesores");
                renglon++;
            } while (renglon <= 10);
        }
    }
}
