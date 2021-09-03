
namespace DiegoAyala_Ej3_02L
{
    partial class Ventana
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_num3 = new System.Windows.Forms.TextBox();
            this.txt_num4 = new System.Windows.Forms.TextBox();
            this.lb_num1 = new System.Windows.Forms.Label();
            this.lb_num2 = new System.Windows.Forms.Label();
            this.lb_num3 = new System.Windows.Forms.Label();
            this.lb_num4 = new System.Windows.Forms.Label();
            this.lbt_mayor = new System.Windows.Forms.Label();
            this.lbt_menor = new System.Windows.Forms.Label();
            this.lb_advertencia = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbr_menor = new System.Windows.Forms.Label();
            this.lbr_mayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(152, 53);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(125, 27);
            this.txt_num1.TabIndex = 0;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(152, 112);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(125, 27);
            this.txt_num2.TabIndex = 1;
            // 
            // txt_num3
            // 
            this.txt_num3.Location = new System.Drawing.Point(152, 179);
            this.txt_num3.Name = "txt_num3";
            this.txt_num3.Size = new System.Drawing.Size(125, 27);
            this.txt_num3.TabIndex = 2;
            // 
            // txt_num4
            // 
            this.txt_num4.Location = new System.Drawing.Point(152, 252);
            this.txt_num4.Name = "txt_num4";
            this.txt_num4.Size = new System.Drawing.Size(125, 27);
            this.txt_num4.TabIndex = 3;
            // 
            // lb_num1
            // 
            this.lb_num1.AutoSize = true;
            this.lb_num1.Location = new System.Drawing.Point(56, 60);
            this.lb_num1.Name = "lb_num1";
            this.lb_num1.Size = new System.Drawing.Size(75, 20);
            this.lb_num1.TabIndex = 4;
            this.lb_num1.Text = "Numero 1";
            // 
            // lb_num2
            // 
            this.lb_num2.AutoSize = true;
            this.lb_num2.Location = new System.Drawing.Point(56, 115);
            this.lb_num2.Name = "lb_num2";
            this.lb_num2.Size = new System.Drawing.Size(75, 20);
            this.lb_num2.TabIndex = 5;
            this.lb_num2.Text = "Numero 2";
            // 
            // lb_num3
            // 
            this.lb_num3.AutoSize = true;
            this.lb_num3.Location = new System.Drawing.Point(56, 182);
            this.lb_num3.Name = "lb_num3";
            this.lb_num3.Size = new System.Drawing.Size(75, 20);
            this.lb_num3.TabIndex = 6;
            this.lb_num3.Text = "Numero 3";
            // 
            // lb_num4
            // 
            this.lb_num4.AutoSize = true;
            this.lb_num4.Location = new System.Drawing.Point(56, 255);
            this.lb_num4.Name = "lb_num4";
            this.lb_num4.Size = new System.Drawing.Size(75, 20);
            this.lb_num4.TabIndex = 7;
            this.lb_num4.Text = "Numero 4";
            // 
            // lbt_mayor
            // 
            this.lbt_mayor.AutoSize = true;
            this.lbt_mayor.Location = new System.Drawing.Point(417, 75);
            this.lbt_mayor.Name = "lbt_mayor";
            this.lbt_mayor.Size = new System.Drawing.Size(116, 20);
            this.lbt_mayor.TabIndex = 8;
            this.lbt_mayor.Text = "Numero mayor :";
            // 
            // lbt_menor
            // 
            this.lbt_menor.AutoSize = true;
            this.lbt_menor.Location = new System.Drawing.Point(417, 125);
            this.lbt_menor.Name = "lbt_menor";
            this.lbt_menor.Size = new System.Drawing.Size(117, 20);
            this.lbt_menor.TabIndex = 10;
            this.lbt_menor.Text = "Numero menor :";
            // 
            // lb_advertencia
            // 
            this.lb_advertencia.AutoSize = true;
            this.lb_advertencia.Location = new System.Drawing.Point(348, 196);
            this.lb_advertencia.Name = "lb_advertencia";
            this.lb_advertencia.Size = new System.Drawing.Size(366, 20);
            this.lb_advertencia.TabIndex = 12;
            this.lb_advertencia.Text = "*Los numeros deben de ser mayores a 0 y no repetirse";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(238, 316);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(94, 29);
            this.btn_calcular.TabIndex = 13;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(416, 316);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(94, 29);
            this.btn_limpiar.TabIndex = 14;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(589, 316);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(94, 29);
            this.btn_cerrar.TabIndex = 15;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbr_menor
            // 
            this.lbr_menor.AutoSize = true;
            this.lbr_menor.Location = new System.Drawing.Point(571, 125);
            this.lbr_menor.Name = "lbr_menor";
            this.lbr_menor.Size = new System.Drawing.Size(12, 20);
            this.lbr_menor.TabIndex = 17;
            this.lbr_menor.Text = ".";
            this.lbr_menor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbr_mayor
            // 
            this.lbr_mayor.AutoSize = true;
            this.lbr_mayor.Location = new System.Drawing.Point(571, 75);
            this.lbr_mayor.Name = "lbr_mayor";
            this.lbr_mayor.Size = new System.Drawing.Size(12, 20);
            this.lbr_mayor.TabIndex = 18;
            this.lbr_mayor.Text = ".";
            // 
            // Ventana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbr_mayor);
            this.Controls.Add(this.lbr_menor);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lb_advertencia);
            this.Controls.Add(this.lbt_menor);
            this.Controls.Add(this.lbt_mayor);
            this.Controls.Add(this.lb_num4);
            this.Controls.Add(this.lb_num3);
            this.Controls.Add(this.lb_num2);
            this.Controls.Add(this.lb_num1);
            this.Controls.Add(this.txt_num4);
            this.Controls.Add(this.txt_num3);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Name = "Ventana";
            this.Text = "Calculo de numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_num3;
        private System.Windows.Forms.TextBox txt_num4;
        private System.Windows.Forms.Label lb_num1;
        private System.Windows.Forms.Label lb_num2;
        private System.Windows.Forms.Label lb_num3;
        private System.Windows.Forms.Label lb_num4;
        private System.Windows.Forms.Label lbt_mayor;
        private System.Windows.Forms.Label lbt_menor;
        private System.Windows.Forms.Label lb_advertencia;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbr_mayor;
        private System.Windows.Forms.Label lbr_menor;
        private System.Windows.Forms.Label label2;
    }
}

