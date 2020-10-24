namespace Tarea_4.Formularios
{
    partial class FrmE3
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
            this.txtnuevosalario = new System.Windows.Forms.TextBox();
            this.txtaumento = new System.Windows.Forms.TextBox();
            this.txtporcentaje = new System.Windows.Forms.TextBox();
            this.txtsalariobase = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(372, 294);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 31);
            this.btncalcular.TabIndex = 24;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtnuevosalario
            // 
            this.txtnuevosalario.Location = new System.Drawing.Point(501, 237);
            this.txtnuevosalario.Name = "txtnuevosalario";
            this.txtnuevosalario.Size = new System.Drawing.Size(115, 20);
            this.txtnuevosalario.TabIndex = 22;
            // 
            // txtaumento
            // 
            this.txtaumento.Location = new System.Drawing.Point(405, 237);
            this.txtaumento.Name = "txtaumento";
            this.txtaumento.Size = new System.Drawing.Size(77, 20);
            this.txtaumento.TabIndex = 21;
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.Location = new System.Drawing.Point(326, 237);
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(51, 20);
            this.txtporcentaje.TabIndex = 20;
            // 
            // txtsalariobase
            // 
            this.txtsalariobase.Location = new System.Drawing.Point(185, 237);
            this.txtsalariobase.Name = "txtsalariobase";
            this.txtsalariobase.Size = new System.Drawing.Size(100, 20);
            this.txtsalariobase.TabIndex = 19;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(311, 160);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(211, 20);
            this.txtnombre.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nuevo Salario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Aumento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Salario Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // FrmE3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtnuevosalario);
            this.Controls.Add(this.txtaumento);
            this.Controls.Add(this.txtporcentaje);
            this.Controls.Add(this.txtsalariobase);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE3";
            this.Text = "FrmE3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtnuevosalario;
        private System.Windows.Forms.TextBox txtaumento;
        private System.Windows.Forms.TextBox txtporcentaje;
        private System.Windows.Forms.TextBox txtsalariobase;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}