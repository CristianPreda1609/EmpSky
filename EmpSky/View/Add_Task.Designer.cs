namespace EmpSky
{
    partial class Add_Task
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
            this.Descriere_Text = new System.Windows.Forms.TextBox();
            this.Data_Limita_Text = new System.Windows.Forms.TextBox();
            this.Salvare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descriere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Limita";
            // 
            // Descriere_Text
            // 
            this.Descriere_Text.Location = new System.Drawing.Point(12, 66);
            this.Descriere_Text.Multiline = true;
            this.Descriere_Text.Name = "Descriere_Text";
            this.Descriere_Text.Size = new System.Drawing.Size(138, 57);
            this.Descriere_Text.TabIndex = 2;
            this.Descriere_Text.TextChanged += new System.EventHandler(this.Descriere_Text_TextChanged);
            // 
            // Data_Limita_Text
            // 
            this.Data_Limita_Text.Location = new System.Drawing.Point(310, 66);
            this.Data_Limita_Text.Multiline = true;
            this.Data_Limita_Text.Name = "Data_Limita_Text";
            this.Data_Limita_Text.Size = new System.Drawing.Size(163, 57);
            this.Data_Limita_Text.TabIndex = 3;
            this.Data_Limita_Text.TextChanged += new System.EventHandler(this.Data_Limita_Text_TextChanged);
            // 
            // Salvare
            // 
            this.Salvare.Location = new System.Drawing.Point(18, 129);
            this.Salvare.Name = "Salvare";
            this.Salvare.Size = new System.Drawing.Size(455, 62);
            this.Salvare.TabIndex = 4;
            this.Salvare.Text = "Salvare";
            this.Salvare.UseVisualStyleBackColor = true;
            this.Salvare.Click += new System.EventHandler(this.Salvare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Format data: yyyy-MM-ddTHH:mm:ss";
            // 
            // Add_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 265);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Salvare);
            this.Controls.Add(this.Data_Limita_Text);
            this.Controls.Add(this.Descriere_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Task";
            this.Text = "Add_Task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Descriere_Text;
        private System.Windows.Forms.TextBox Data_Limita_Text;
        private System.Windows.Forms.Button Salvare;
        private System.Windows.Forms.Label label3;
    }
}