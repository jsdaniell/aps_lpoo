namespace Motocicleta
{
    partial class Motocicleta
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
            this.labelMoto = new System.Windows.Forms.Label();
            this.stdMoto = new System.Windows.Forms.Label();
            this.labelMarcha = new System.Windows.Forms.Label();
            this.stdMarcha = new System.Windows.Forms.Label();
            this.infoMoto = new System.Windows.Forms.GroupBox();
            this.labelCor = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMenorMarcha = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.infoMoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMoto
            // 
            this.labelMoto.AutoSize = true;
            this.labelMoto.Location = new System.Drawing.Point(12, 9);
            this.labelMoto.Name = "labelMoto";
            this.labelMoto.Size = new System.Drawing.Size(85, 13);
            this.labelMoto.TabIndex = 1;
            this.labelMoto.Text = "Estado da Moto:";
            // 
            // stdMoto
            // 
            this.stdMoto.AutoSize = true;
            this.stdMoto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.stdMoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stdMoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stdMoto.Location = new System.Drawing.Point(15, 35);
            this.stdMoto.Name = "stdMoto";
            this.stdMoto.Size = new System.Drawing.Size(56, 15);
            this.stdMoto.TabIndex = 2;
            this.stdMoto.Text = "Desligada";
            // 
            // labelMarcha
            // 
            this.labelMarcha.AutoSize = true;
            this.labelMarcha.Location = new System.Drawing.Point(12, 64);
            this.labelMarcha.Name = "labelMarcha";
            this.labelMarcha.Size = new System.Drawing.Size(73, 13);
            this.labelMarcha.TabIndex = 3;
            this.labelMarcha.Text = "Marcha Atual:";
            // 
            // stdMarcha
            // 
            this.stdMarcha.AutoSize = true;
            this.stdMarcha.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.stdMarcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stdMarcha.Location = new System.Drawing.Point(15, 93);
            this.stdMarcha.Name = "stdMarcha";
            this.stdMarcha.Size = new System.Drawing.Size(56, 15);
            this.stdMarcha.TabIndex = 4;
            this.stdMarcha.Text = "Desligada";
            // 
            // infoMoto
            // 
            this.infoMoto.Controls.Add(this.labelCor);
            this.infoMoto.Controls.Add(this.txtCor);
            this.infoMoto.Controls.Add(this.labelModelo);
            this.infoMoto.Controls.Add(this.txtModelo);
            this.infoMoto.Controls.Add(this.labelMarca);
            this.infoMoto.Controls.Add(this.txtMarca);
            this.infoMoto.Controls.Add(this.button1);
            this.infoMoto.Location = new System.Drawing.Point(12, 168);
            this.infoMoto.Name = "infoMoto";
            this.infoMoto.Size = new System.Drawing.Size(242, 102);
            this.infoMoto.TabIndex = 5;
            this.infoMoto.TabStop = false;
            this.infoMoto.Text = "Informações da Moto";
            // 
            // labelCor
            // 
            this.labelCor.AutoSize = true;
            this.labelCor.Location = new System.Drawing.Point(6, 78);
            this.labelCor.Name = "labelCor";
            this.labelCor.Size = new System.Drawing.Size(26, 13);
            this.labelCor.TabIndex = 6;
            this.labelCor.Text = "Cor:";
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(52, 75);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 5;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(6, 52);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 4;
            this.labelModelo.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(52, 49);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 3;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(6, 26);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(52, 23);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nova Moto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Maior Marcha: 5";
            // 
            // labelMenorMarcha
            // 
            this.labelMenorMarcha.AutoSize = true;
            this.labelMenorMarcha.Location = new System.Drawing.Point(132, 84);
            this.labelMenorMarcha.Name = "labelMenorMarcha";
            this.labelMenorMarcha.Size = new System.Drawing.Size(88, 13);
            this.labelMenorMarcha.TabIndex = 8;
            this.labelMenorMarcha.Text = "Menor Marcha: 0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ligar/Desligar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LigaDesliga);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 52);
            this.button3.TabIndex = 7;
            this.button3.Text = "SUBIR MARCHA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 52);
            this.button4.TabIndex = 8;
            this.button4.Text = "DESCER MARCHA";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Motocicleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labelMenorMarcha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.infoMoto);
            this.Controls.Add(this.stdMarcha);
            this.Controls.Add(this.labelMarcha);
            this.Controls.Add(this.stdMoto);
            this.Controls.Add(this.labelMoto);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 316);
            this.MinimumSize = new System.Drawing.Size(275, 315);
            this.Name = "Motocicleta";
            this.Text = "Motocicleta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.infoMoto.ResumeLayout(false);
            this.infoMoto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoto;
        private System.Windows.Forms.Label stdMoto;
        private System.Windows.Forms.Label labelMarcha;
        private System.Windows.Forms.Label stdMarcha;
        private System.Windows.Forms.GroupBox infoMoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label labelCor;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMenorMarcha;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

