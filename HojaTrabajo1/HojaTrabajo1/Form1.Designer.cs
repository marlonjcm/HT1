namespace HojaTrabajo1
{
    partial class HT1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.entrada1 = new System.Windows.Forms.TextBox();
            this.entrada2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.entrada3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.entrada4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.op1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input 1";
            // 
            // entrada1
            // 
            this.entrada1.Location = new System.Drawing.Point(115, 40);
            this.entrada1.Name = "entrada1";
            this.entrada1.Size = new System.Drawing.Size(100, 20);
            this.entrada1.TabIndex = 1;
            // 
            // entrada2
            // 
            this.entrada2.Location = new System.Drawing.Point(115, 81);
            this.entrada2.Name = "entrada2";
            this.entrada2.Size = new System.Drawing.Size(100, 20);
            this.entrada2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input 2";
            // 
            // entrada3
            // 
            this.entrada3.Location = new System.Drawing.Point(115, 121);
            this.entrada3.Name = "entrada3";
            this.entrada3.Size = new System.Drawing.Size(100, 20);
            this.entrada3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input 3";
            // 
            // entrada4
            // 
            this.entrada4.Location = new System.Drawing.Point(115, 162);
            this.entrada4.Name = "entrada4";
            this.entrada4.Size = new System.Drawing.Size(100, 20);
            this.entrada4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Input 4";
            // 
            // op1
            // 
            this.op1.Location = new System.Drawing.Point(29, 236);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(75, 23);
            this.op1.TabIndex = 8;
            this.op1.Text = "Hipotenusa";
            this.op1.UseVisualStyleBackColor = true;
            this.op1.Click += new System.EventHandler(this.op1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Vocales";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Invertir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(152, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Regla de 3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(342, 278);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Resultado";
            // 
            // HT1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.entrada4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.entrada3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entrada2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.entrada1);
            this.Controls.Add(this.label1);
            this.Name = "HT1";
            this.Text = "HT1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entrada1;
        private System.Windows.Forms.TextBox entrada2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox entrada3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox entrada4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button op1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label5;
    }
}

