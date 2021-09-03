using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiegoAyala_Ej1_02L
{
    public partial class pantalla_1 : Form
    {
        public pantalla_1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double a, b, c, x1, x2;

            //obtencion de datos
            a = Convert.ToDouble(txt_a.Text);
            b = Convert.ToDouble(txt_b.Text);
            c = Convert.ToDouble(txt_c.Text);

            //operaciones
            x1 = (-1 * b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            x2 = (-1 * b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            //impresion de resultados
            lbr_x1.Text = Convert.ToString(x1);
            lbr_x2.Text = Convert.ToString(x2);

        }

     
        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            //limpiando campos...
            txt_a.Clear();
            txt_b.Clear();
            txt_c.Clear();
            lbr_x1.Text = "";
            lbr_x2.Text = "";
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();//termina la aplicacion
        }
    }
}
