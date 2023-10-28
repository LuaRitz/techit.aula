namespace au1
{
    partial class calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.va1 = new System.Windows.Forms.Label();
            this.va2 = new System.Windows.Forms.Label();
            this.v1t = new System.Windows.Forms.TextBox();
            this.v2t = new System.Windows.Forms.TextBox();
            this.soma = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.resul = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // va1
            // 
            this.va1.AutoSize = true;
            this.va1.Location = new System.Drawing.Point(56, 37);
            this.va1.Name = "va1";
            this.va1.Size = new System.Drawing.Size(40, 13);
            this.va1.TabIndex = 0;
            this.va1.Text = "Valor 1";
            // 
            // va2
            // 
            this.va2.AutoSize = true;
            this.va2.Location = new System.Drawing.Point(56, 63);
            this.va2.Name = "va2";
            this.va2.Size = new System.Drawing.Size(40, 13);
            this.va2.TabIndex = 1;
            this.va2.Text = "Valor 2";
            // 
            // v1t
            // 
            this.v1t.Location = new System.Drawing.Point(97, 34);
            this.v1t.Name = "v1t";
            this.v1t.Size = new System.Drawing.Size(209, 20);
            this.v1t.TabIndex = 2;
            // 
            // v2t
            // 
            this.v2t.Location = new System.Drawing.Point(97, 60);
            this.v2t.Name = "v2t";
            this.v2t.Size = new System.Drawing.Size(209, 20);
            this.v2t.TabIndex = 3;
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(10, 129);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(75, 23);
            this.soma.TabIndex = 4;
            this.soma.Text = "Soma";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.soma_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(92, 129);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 23);
            this.sub.TabIndex = 5;
            this.sub.Text = "Subtração";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(173, 129);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(78, 23);
            this.mult.TabIndex = 6;
            this.mult.Text = "Multiplicação";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(257, 129);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 7;
            this.div.Text = "Divisão";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // resul
            // 
            this.resul.AutoSize = true;
            this.resul.Location = new System.Drawing.Point(36, 96);
            this.resul.Name = "resul";
            this.resul.Size = new System.Drawing.Size(55, 13);
            this.resul.TabIndex = 8;
            this.resul.Text = "Resultado";
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 187);
            this.Controls.Add(this.resul);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.soma);
            this.Controls.Add(this.v2t);
            this.Controls.Add(this.v1t);
            this.Controls.Add(this.va2);
            this.Controls.Add(this.va1);
            this.Name = "calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label va1;
        private System.Windows.Forms.Label va2;
        private System.Windows.Forms.TextBox v1t;
        private System.Windows.Forms.TextBox v2t;
        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Label resul;
    }
}

