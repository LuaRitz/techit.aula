namespace au1
{
    partial class aluno
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
            this.cadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomet = new System.Windows.Forms.TextBox();
            this.rgt = new System.Windows.Forms.TextBox();
            this.emailt = new System.Windows.Forms.TextBox();
            this.fonet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.casat = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(206, 36);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "RG";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "EMAIL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nomet
            // 
            this.nomet.Location = new System.Drawing.Point(80, 11);
            this.nomet.Name = "nomet";
            this.nomet.Size = new System.Drawing.Size(100, 20);
            this.nomet.TabIndex = 6;
            this.nomet.TextChanged += new System.EventHandler(this.nomet_TextChanged);
            // 
            // rgt
            // 
            this.rgt.Location = new System.Drawing.Point(80, 38);
            this.rgt.Name = "rgt";
            this.rgt.Size = new System.Drawing.Size(100, 20);
            this.rgt.TabIndex = 7;
            this.rgt.TextChanged += new System.EventHandler(this.rgt_TextChanged);
            // 
            // emailt
            // 
            this.emailt.Location = new System.Drawing.Point(80, 64);
            this.emailt.Name = "emailt";
            this.emailt.Size = new System.Drawing.Size(100, 20);
            this.emailt.TabIndex = 8;
            this.emailt.TextChanged += new System.EventHandler(this.emailt_TextChanged);
            // 
            // fonet
            // 
            this.fonet.Location = new System.Drawing.Point(80, 92);
            this.fonet.Name = "fonet";
            this.fonet.Size = new System.Drawing.Size(100, 20);
            this.fonet.TabIndex = 9;
            this.fonet.TextChanged += new System.EventHandler(this.fonet_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "fone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Residência";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // casat
            // 
            this.casat.Location = new System.Drawing.Point(80, 118);
            this.casat.Name = "casat";
            this.casat.Size = new System.Drawing.Size(100, 20);
            this.casat.TabIndex = 12;
            this.casat.TextChanged += new System.EventHandler(this.casat_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "receber notificações";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 170);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.casat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fonet);
            this.Controls.Add(this.emailt);
            this.Controls.Add(this.rgt);
            this.Controls.Add(this.nomet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cadastrar);
            this.Name = "aluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomet;
        private System.Windows.Forms.TextBox rgt;
        private System.Windows.Forms.TextBox emailt;
        private System.Windows.Forms.TextBox fonet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox casat;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}