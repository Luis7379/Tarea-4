using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_4.Clases;

namespace Tarea_4.Formularios
{
    public partial class FrmE3 : Form
    {
        Clases.salarionuevo SN=new Clases.salarionuevo();
        public FrmE3()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double salariobase, porcentaje, suma, aumento;
            salariobase = Convert.ToDouble(txtsalariobase.Text);
            porcentaje = Convert.ToDouble(txtporcentaje.Text);
            txtaumento.Text = SN.Aumento(salariobase, porcentaje).ToString();
            aumento = Convert.ToDouble(txtaumento.Text);
            suma = salariobase + aumento;
            txtnuevosalario.Text = suma.ToString();


        }

      
    }
}

