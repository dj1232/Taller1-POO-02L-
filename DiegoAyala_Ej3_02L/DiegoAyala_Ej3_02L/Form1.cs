using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiegoAyala_Ej3_02L
{
    public partial class Ventana : Form
    {
        private void corregir()
        {
            MessageBox.Show("Tiene que digitar un numero positivo mayor a 0 ");
            txt_num1.Clear();
            txt_num2.Clear();
            txt_num3.Clear();
            txt_num4.Clear();
            lbr_mayor.Text = "";
            lbr_menor.Text = "";

        }//fin funcion corregir

        public Ventana()
        {
            InitializeComponent();
        }
        
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            Int16 num1, num2, num3, num4, mayor, menor, suma;

            //obtencion de datos
            num1 = Convert.ToInt16(txt_num1.Text);
            num2 = Convert.ToInt16(txt_num2.Text);
            num3 = Convert.ToInt16(txt_num3.Text);
            num4 = Convert.ToInt16(txt_num4.Text);
       
            //proceso
            if(num1>num2 && num1>num3 && num1> num4)
            {
                mayor = num1;
            }
            else if(num2 > num1 && num2 > num3 && num2 > num4)
            {
                mayor = num2;
            }
            else if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                mayor = num3;
            }
            else 
            {
                mayor = num4;
            }//fin determinar mayor

            if (num1 < num2 && num1 < num3 && num1 < num4)
            {
                menor = num1;
            }
            else if (num2 < num1 && num2 < num3 && num2 < num4)
            {
                menor = num2;
            }
            else if (num3 < num1 && num3 < num2 && num3 < num4)
            {
                menor = num3;
            }
            else 
            {
                menor = num4;
            }//fin determinar menor

            if (menor > 10)
            {
                mayor += 10;
            }

            if (mayor < 50)
            {
                menor -= 5;
            }

            //impresion de resultados
            lbr_mayor.Text = Convert.ToString(mayor);
            lbr_menor.Text = Convert.ToString(menor);

            if (num1 == num2 || num1 == num3 || num1 == num4 || num2 == num1 || num2 == num3 || num2 == num4 || num3 == num1 || num3 == num2 || num3 == num4 || num4 == num1 || num4 == num2 || num4 == num3)
            {
                MessageBox.Show("Los numeros no pueden repetirse ");
                txt_num1.Clear();
                txt_num2.Clear();
                txt_num3.Clear();
                txt_num4.Clear();
                lbr_mayor.Text = "";
                lbr_menor.Text = "";
            }

            suma = (short)(num1 + num2 + num3 + num4);
            if (suma >= 200)
            {
                MessageBox.Show("La suma de todos los numeros no puede ser mayor a 200 ");
                txt_num1.Clear();
                txt_num2.Clear();
                txt_num3.Clear();
                txt_num4.Clear();
                lbr_mayor.Text = "";
                lbr_menor.Text = "";
            }
            if (num1 <= 0 || num2<=0 || num3<=0 || num4<=0)
            {
                corregir();
            }
        }//fin click calcular

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_num1.Clear();
            txt_num2.Clear();
            txt_num3.Clear();
            txt_num4.Clear();
            lbr_mayor.Text = "";
            lbr_menor.Text = "";
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
