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
    public partial class FrmE1 : Form
    {
        public FrmE1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double sueldob, sueldoh, horase, sueldohe, sueldoneto, deduccion, total;
            sueldob = double.Parse(txtsueldon.Text);
            horase = double.Parse(txthorase.Text);
            sueldohe = double.Parse(txtpreciohe.Text);
            sueldoh = horase * sueldohe;
            sueldoneto = sueldob + sueldoh;
            deduccion = sueldoneto * 0.05;
            total = sueldoneto - deduccion;
            
            txtsueldoneto.Text = sueldoneto.ToString();
            txtdeduccion.Text = deduccion.ToString();
            txtsueldototal.Text = total.ToString();

        }
    }
}
