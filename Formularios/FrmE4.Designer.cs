namespace Tarea_4.Formularios
{
    partial class FrmE4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtcuotamensual = new System.Windows.Forms.TextBox();
            this.txtplazoanual = new System.Windows.Forms.TextBox();
            this.txtaumento = new System.Windows.Forms.TextBox();
            this.txtporcentaje = new System.Windows.Forms.TextBox();
            this.txtprecioalcontado = new System.Windows.Forms.TextBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(246, 218);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 31);
            this.btncalcular.TabIndex = 28;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtcuotamensual
            // 
            this.txtcuotamensual.Location = new System.Drawing.Point(227, 175);
            this.txtcuotamensual.Name = "txtcuotamensual";
            this.txtcuotamensual.Size = new System.Drawing.Size(119, 20);
            this.txtcuotamensual.TabIndex = 26;
            // 
            // txtplazoanual
            // 
            this.txtplazoanual.Location = new System.Drawing.Point(390, 112);
            this.txtplazoanual.Name = "txtplazoanual";
            this.txtplazoanual.Size = new System.Drawing.Size(108, 20);
            this.txtplazoanual.TabIndex = 25;
            // 
            // txtaumento
            // 
            this.txtaumento.Location = new System.Drawing.Point(295, 112);
            this.txtaumento.Name = "txtaumento";
            this.txtaumento.Size = new System.Drawing.Size(68, 20);
            this.txtaumento.TabIndex = 24;
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.Location = new System.Drawing.Point(214, 112);
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(53, 20);
            this.txtporcentaje.TabIndex = 23;
            // 
            // txtprecioalcontado
            // 
            this.txtprecioalcontado.Location = new System.Drawing.Point(61, 115);
            this.txtprecioalcontado.Name = "txtprecioalcontado";
            this.txtprecioalcontado.Size = new System.Drawing.Size(108, 20);
            this.txtprecioalcontado.TabIndex = 22;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(210, 47);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(153, 20);
            this.txtproducto.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cuota Mensual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Plazo Anual + Aumento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Aumento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Precio Al Contado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto";
            // 
            // FrmE4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(555, 273);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtcuotamensual);
            this.Controls.Add(this.txtplazoanual);
            this.Controls.Add(this.txtaumento);
            this.Controls.Add(this.txtporcentaje);
            this.Controls.Add(this.txtprecioalcontado);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE4";
            this.Text = "FrmE4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtcuotamensual;
        private System.Windows.Forms.TextBox txtplazoanual;
        private System.Windows.Forms.TextBox txtaumento;
        private System.Windows.Forms.TextBox txtporcentaje;
        private System.Windows.Forms.TextBox txtprecioalcontado;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}