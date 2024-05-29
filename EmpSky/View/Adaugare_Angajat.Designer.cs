namespace EmpSky
{
    partial class Adaugare_Angajat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adaugare_Angajat));
            this.Nume = new System.Windows.Forms.TextBox();
            this.Prenume_Titlu = new System.Windows.Forms.TextBox();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.Departament_Titlu = new System.Windows.Forms.TextBox();
            this.Departament = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Salvare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(12, 44);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(111, 26);
            this.Nume.TabIndex = 0;
            this.Nume.TextChanged += new System.EventHandler(this.Nume_TextChanged);
            // 
            // Prenume_Titlu
            // 
            this.Prenume_Titlu.Location = new System.Drawing.Point(12, 76);
            this.Prenume_Titlu.Name = "Prenume_Titlu";
            this.Prenume_Titlu.ReadOnly = true;
            this.Prenume_Titlu.Size = new System.Drawing.Size(111, 26);
            this.Prenume_Titlu.TabIndex = 2;
            this.Prenume_Titlu.Text = "Prenume";
            this.Prenume_Titlu.TextChanged += new System.EventHandler(this.Prenume_Titlu_TextChanged);
            // 
            // Prenume
            // 
            this.Prenume.Location = new System.Drawing.Point(12, 108);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(111, 26);
            this.Prenume.TabIndex = 3;
            this.Prenume.TextChanged += new System.EventHandler(this.Prenume_TextChanged);
            // 
            // Departament_Titlu
            // 
            this.Departament_Titlu.Location = new System.Drawing.Point(12, 140);
            this.Departament_Titlu.Name = "Departament_Titlu";
            this.Departament_Titlu.ReadOnly = true;
            this.Departament_Titlu.Size = new System.Drawing.Size(111, 26);
            this.Departament_Titlu.TabIndex = 6;
            this.Departament_Titlu.Text = "Departament";
            this.Departament_Titlu.TextChanged += new System.EventHandler(this.Departament_Titlu_TextChanged);
            // 
            // Departament
            // 
            this.Departament.Location = new System.Drawing.Point(12, 172);
            this.Departament.Name = "Departament";
            this.Departament.Size = new System.Drawing.Size(111, 26);
            this.Departament.TabIndex = 8;
            this.Departament.TextChanged += new System.EventHandler(this.Departament_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(111, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Nume";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Salvare
            // 
            this.Salvare.Location = new System.Drawing.Point(12, 204);
            this.Salvare.Name = "Salvare";
            this.Salvare.Size = new System.Drawing.Size(234, 74);
            this.Salvare.TabIndex = 10;
            this.Salvare.Text = "Salvare";
            this.Salvare.UseVisualStyleBackColor = true;
            this.Salvare.Click += new System.EventHandler(this.Salvare_Click);
            // 
            // Adaugare_Angajat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 303);
            this.Controls.Add(this.Salvare);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Departament);
            this.Controls.Add(this.Departament_Titlu);
            this.Controls.Add(this.Prenume);
            this.Controls.Add(this.Prenume_Titlu);
            this.Controls.Add(this.Nume);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adaugare_Angajat";
            this.Text = "Adaugare_Angajat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.TextBox Prenume_Titlu;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.TextBox Departament_Titlu;
        private System.Windows.Forms.TextBox Departament;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Salvare;
    }
}