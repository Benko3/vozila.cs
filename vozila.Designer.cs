namespace Vozila
{
    partial class Form1
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
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.Label();
            this.txtGodinaProizvodnje = new System.Windows.Forms.Label();
            this.txtBrojKotaca = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnObradi = new System.Windows.Forms.Button();
            this.txtIspisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(411, 45);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(279, 299);
            this.txtIspis.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.AutoSize = true;
            this.txtModel.Location = new System.Drawing.Point(64, 57);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(52, 20);
            this.txtModel.TabIndex = 1;
            this.txtModel.Text = "Model";
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.AutoSize = true;
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(36, 141);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(145, 20);
            this.txtGodinaProizvodnje.TabIndex = 2;
            this.txtGodinaProizvodnje.Text = "Godina proizvodnje";
            // 
            // txtBrojKotaca
            // 
            this.txtBrojKotaca.AutoSize = true;
            this.txtBrojKotaca.Location = new System.Drawing.Point(51, 219);
            this.txtBrojKotaca.Name = "txtBrojKotaca";
            this.txtBrojKotaca.Size = new System.Drawing.Size(89, 20);
            this.txtBrojKotaca.TabIndex = 3;
            this.txtBrojKotaca.Text = "Broj kotača";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 164);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(40, 258);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 6;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(12, 305);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(86, 39);
            this.btnUnesi.TabIndex = 7;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnObradi
            // 
            this.btnObradi.Location = new System.Drawing.Point(129, 305);
            this.btnObradi.Name = "btnObradi";
            this.btnObradi.Size = new System.Drawing.Size(87, 39);
            this.btnObradi.TabIndex = 8;
            this.btnObradi.Text = "Obradi";
            this.btnObradi.UseVisualStyleBackColor = true;
            this.btnObradi.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtIspisi
            // 
            this.txtIspisi.Location = new System.Drawing.Point(55, 362);
            this.txtIspisi.Name = "txtIspisi";
            this.txtIspisi.Size = new System.Drawing.Size(113, 47);
            this.txtIspisi.TabIndex = 9;
            this.txtIspisi.Text = "Ispisi";
            this.txtIspisi.UseVisualStyleBackColor = true;
            this.txtIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIspisi);
            this.Controls.Add(this.btnObradi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtBrojKotaca);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtIspis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Label txtModel;
        private System.Windows.Forms.Label txtGodinaProizvodnje;
        private System.Windows.Forms.Label txtBrojKotaca;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnObradi;
        private System.Windows.Forms.Button txtIspisi;
    }
}

