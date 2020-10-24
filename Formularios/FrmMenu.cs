using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_4.Formularios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FrmE1();
            formulario1.Show();
        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            Form formulario2 = new FrmE2();
            formulario2.Show();
        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            Form formulario3 = new FrmE3();
            formulario3.Show();
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            Form formulario4 = new FrmE3();
            formulario4.Show();
        }
    }
    
}
