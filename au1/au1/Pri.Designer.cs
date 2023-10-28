namespace au1
{
    partial class Pri
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
            this.aluno = new System.Windows.Forms.Button();
            this.prof = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aluno
            // 
            this.aluno.Location = new System.Drawing.Point(12, 12);
            this.aluno.Name = "aluno";
            this.aluno.Size = new System.Drawing.Size(75, 23);
            this.aluno.TabIndex = 0;
            this.aluno.Text = "Aluno";
            this.aluno.UseVisualStyleBackColor = true;
            this.aluno.Click += new System.EventHandler(this.aluno_Click);
            // 
            // prof
            // 
            this.prof.Location = new System.Drawing.Point(173, 12);
            this.prof.Name = "prof";
            this.prof.Size = new System.Drawing.Size(75, 23);
            this.prof.TabIndex = 1;
            this.prof.Text = "Professor";
            this.prof.UseVisualStyleBackColor = true;
            this.prof.Click += new System.EventHandler(this.prof_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(173, 66);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 3;
            this.calc.Text = "Calculadora";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // Pri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 101);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prof);
            this.Controls.Add(this.aluno);
            this.Name = "Pri";
            this.Text = "Controle Acadêmico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aluno;
        private System.Windows.Forms.Button prof;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calc;
    }
}