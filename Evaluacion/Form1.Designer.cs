namespace Evaluacion
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.TbNumero = new System.Windows.Forms.TextBox();
            this.LbNum = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsumadenum = new System.Windows.Forms.Label();
            this.Lblnummayor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lblnummenor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(78, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAMA QUE INGRESA NUMEROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese un numero:";
            // 
            // TbNumero
            // 
            this.TbNumero.Location = new System.Drawing.Point(215, 82);
            this.TbNumero.Name = "TbNumero";
            this.TbNumero.Size = new System.Drawing.Size(268, 26);
            this.TbNumero.TabIndex = 2;
            this.TbNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LbNum
            // 
            this.LbNum.FormattingEnabled = true;
            this.LbNum.ItemHeight = 20;
            this.LbNum.Location = new System.Drawing.Point(54, 136);
            this.LbNum.Name = "LbNum";
            this.LbNum.Size = new System.Drawing.Size(429, 164);
            this.LbNum.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(514, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "INGRESAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Suma de todos los numeros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Numero mayor";
            // 
            // lblsumadenum
            // 
            this.lblsumadenum.AutoSize = true;
            this.lblsumadenum.Location = new System.Drawing.Point(527, 179);
            this.lblsumadenum.Name = "lblsumadenum";
            this.lblsumadenum.Size = new System.Drawing.Size(0, 20);
            this.lblsumadenum.TabIndex = 7;
            this.lblsumadenum.Click += new System.EventHandler(this.lblsumadenum_Click);
            // 
            // Lblnummayor
            // 
            this.Lblnummayor.AutoSize = true;
            this.Lblnummayor.Location = new System.Drawing.Point(527, 261);
            this.Lblnummayor.Name = "Lblnummayor";
            this.Lblnummayor.Size = new System.Drawing.Size(0, 20);
            this.Lblnummayor.TabIndex = 8;
            this.Lblnummayor.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Numero menor";
            // 
            // Lblnummenor
            // 
            this.Lblnummenor.AutoSize = true;
            this.Lblnummenor.Location = new System.Drawing.Point(535, 339);
            this.Lblnummenor.Name = "Lblnummenor";
            this.Lblnummenor.Size = new System.Drawing.Size(0, 20);
            this.Lblnummenor.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lblnummenor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lblnummayor);
            this.Controls.Add(this.lblsumadenum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LbNum);
            this.Controls.Add(this.TbNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNumero;
        private System.Windows.Forms.ListBox LbNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsumadenum;
        private System.Windows.Forms.Label Lblnummayor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lblnummenor;
    }
}

