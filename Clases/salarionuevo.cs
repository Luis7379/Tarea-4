using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4.Clases
{
    class salarionuevo
    {
        public double Aumento(double salario, double porcentaje)
        {
            double aumento;
            aumento = salario * porcentaje;
            return aumento;
        }
    }
}
