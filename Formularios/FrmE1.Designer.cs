namespace Tarea_4.Formularios
{
    partial class FrmE1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsueldon = new System.Windows.Forms.TextBox();
            this.txthorase = new System.Windows.Forms.TextBox();
            this.txtpreciohe = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsueldoneto = new System.Windows.Forms.TextBox();
            this.txtdeduccion = new System.Windows.Forms.TextBox();
            this.txtsueldototal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo Normal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas Extras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de cada Hora Extra";
            // 
            // txtsueldon
            // 
            this.txtsueldon.Location = new System.Drawing.Point(172, 57);
            this.txtsueldon.Name = "txtsueldon";
            this.txtsueldon.Size = new System.Drawing.Size(100, 20);
            this.txtsueldon.TabIndex = 4;
            // 
            // txthorase
            // 
            this.txthorase.Location = new System.Drawing.Point(172, 97);
            this.txthorase.Name = "txthorase";
            this.txthorase.Size = new System.Drawing.Size(100, 20);
            this.txthorase.TabIndex = 5;
            // 
            // txtpreciohe
            // 
            this.txtpreciohe.Location = new System.Drawing.Point(172, 130);
            this.txtpreciohe.Name = "txtpreciohe";
            this.txtpreciohe.Size = new System.Drawing.Size(100, 20);
            this.txtpreciohe.TabIndex = 6;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btncalcular.Location = new System.Drawing.Point(206, 167);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sueldo Neto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Deduccion del 5%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sueldo Total";
            // 
            // txtsueldoneto
            // 
            this.txtsueldoneto.Location = new System.Drawing.Point(146, 202);
            this.txtsueldoneto.Name = "txtsueldoneto";
            this.txtsueldoneto.ReadOnly = true;
            this.txtsueldoneto.Size = new System.Drawing.Size(100, 20);
            this.txtsueldoneto.TabIndex = 13;
            // 
            // txtdeduccion
            // 
            this.txtdeduccion.Location = new System.Drawing.Point(394, 199);
            this.txtdeduccion.Name = "txtdeduccion";
            this.txtdeduccion.ReadOnly = true;
            this.txtdeduccion.Size = new System.Drawing.Size(100, 20);
            this.txtdeduccion.TabIndex = 14;
            // 
            // txtsueldototal
            // 
            this.txtsueldototal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtsueldototal.Location = new System.Drawing.Point(394, 243);
            this.txtsueldototal.Name = "txtsueldototal";
            this.txtsueldototal.ReadOnly = true;
            this.txtsueldototal.Size = new System.Drawing.Size(100, 20);
            this.txtsueldototal.TabIndex = 15;
            // 
            // FrmE1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(578, 291);
            this.Controls.Add(this.txtsueldototal);
            this.Controls.Add(this.txtdeduccion);
            this.Controls.Add(this.txtsueldoneto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtpreciohe);
            this.Controls.Add(this.txthorase);
            this.Controls.Add(this.txtsueldon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmE1";
            this.Text = "FrmE1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsueldon;
        private System.Windows.Forms.TextBox txthorase;
        private System.Windows.Forms.TextBox txtpreciohe;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsueldoneto;
        private System.Windows.Forms.TextBox txtdeduccion;
        private System.Windows.Forms.TextBox txtsueldototal;
    }
}