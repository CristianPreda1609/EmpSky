namespace EmpSky
{
    partial class EmpSky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpSky));
            this.Ang_ls = new System.Windows.Forms.ListBox();
            this.Add_Emp = new System.Windows.Forms.Button();
            this.Del_Emp = new System.Windows.Forms.Button();
            this.Id_Dep = new System.Windows.Forms.ListBox();
            this.Date_task = new System.Windows.Forms.ListBox();
            this.calendarulPeLuna = new System.Windows.Forms.MonthCalendar();
            this.Ang_Up = new System.Windows.Forms.Button();
            this.Add_Task = new System.Windows.Forms.Button();
            this.Add_Event = new System.Windows.Forms.Button();
            this.bttn_stergere_angajat = new System.Windows.Forms.Button();
            this.bttn_rm_event = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ang_ls
            // 
            this.Ang_ls.BackColor = System.Drawing.Color.White;
            this.Ang_ls.Cursor = System.Windows.Forms.Cursors.Default;
            this.Ang_ls.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ang_ls.FormattingEnabled = true;
            this.Ang_ls.ItemHeight = 36;
            this.Ang_ls.Location = new System.Drawing.Point(12, 12);
            this.Ang_ls.Name = "Ang_ls";
            this.Ang_ls.Size = new System.Drawing.Size(511, 364);
            this.Ang_ls.TabIndex = 0;
            this.Ang_ls.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Add_Emp
            // 
            this.Add_Emp.Location = new System.Drawing.Point(12, 382);
            this.Add_Emp.Name = "Add_Emp";
            this.Add_Emp.Size = new System.Drawing.Size(233, 57);
            this.Add_Emp.TabIndex = 1;
            this.Add_Emp.Text = "Adaugare Angajat";
            this.Add_Emp.UseVisualStyleBackColor = true;
            this.Add_Emp.Click += new System.EventHandler(this.Add_Emp_Click);
            // 
            // Del_Emp
            // 
            this.Del_Emp.Location = new System.Drawing.Point(281, 382);
            this.Del_Emp.Name = "Del_Emp";
            this.Del_Emp.Size = new System.Drawing.Size(252, 57);
            this.Del_Emp.TabIndex = 2;
            this.Del_Emp.Text = "Stergere Angajat";
            this.Del_Emp.UseVisualStyleBackColor = true;
            this.Del_Emp.Click += new System.EventHandler(this.Del_Emp_Click);
            // 
            // Id_Dep
            // 
            this.Id_Dep.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Dep.FormattingEnabled = true;
            this.Id_Dep.ItemHeight = 36;
            this.Id_Dep.Location = new System.Drawing.Point(529, 12);
            this.Id_Dep.Name = "Id_Dep";
            this.Id_Dep.Size = new System.Drawing.Size(1089, 112);
            this.Id_Dep.TabIndex = 4;
            // 
            // Date_task
            // 
            this.Date_task.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_task.FormattingEnabled = true;
            this.Date_task.ItemHeight = 36;
            this.Date_task.Location = new System.Drawing.Point(539, 365);
            this.Date_task.Name = "Date_task";
            this.Date_task.Size = new System.Drawing.Size(1079, 328);
            this.Date_task.TabIndex = 5;
            this.Date_task.SelectedIndexChanged += new System.EventHandler(this.Date_task_SelectedIndexChanged);
            // 
            // calendarulPeLuna
            // 
            this.calendarulPeLuna.Location = new System.Drawing.Point(539, 100);
            this.calendarulPeLuna.Name = "calendarulPeLuna";
            this.calendarulPeLuna.TabIndex = 6;
            // 
            // Ang_Up
            // 
            this.Ang_Up.Location = new System.Drawing.Point(12, 447);
            this.Ang_Up.Name = "Ang_Up";
            this.Ang_Up.Size = new System.Drawing.Size(133, 59);
            this.Ang_Up.TabIndex = 7;
            this.Ang_Up.Text = "Updatare Angajat";
            this.Ang_Up.UseVisualStyleBackColor = true;
            this.Ang_Up.Click += new System.EventHandler(this.Ang_Up_Click);
            // 
            // Add_Task
            // 
            this.Add_Task.Location = new System.Drawing.Point(192, 447);
            this.Add_Task.Name = "Add_Task";
            this.Add_Task.Size = new System.Drawing.Size(137, 59);
            this.Add_Task.TabIndex = 8;
            this.Add_Task.Text = "Adaugare Task";
            this.Add_Task.UseVisualStyleBackColor = true;
            this.Add_Task.Click += new System.EventHandler(this.Add_Task_Click);
            // 
            // Add_Event
            // 
            this.Add_Event.Location = new System.Drawing.Point(366, 445);
            this.Add_Event.Name = "Add_Event";
            this.Add_Event.Size = new System.Drawing.Size(157, 59);
            this.Add_Event.TabIndex = 9;
            this.Add_Event.Text = "Adaugare Eveniment";
            this.Add_Event.UseVisualStyleBackColor = true;
            this.Add_Event.Click += new System.EventHandler(this.Add_Event_Click);
            // 
            // bttn_stergere_angajat
            // 
            this.bttn_stergere_angajat.Location = new System.Drawing.Point(192, 512);
            this.bttn_stergere_angajat.Name = "bttn_stergere_angajat";
            this.bttn_stergere_angajat.Size = new System.Drawing.Size(137, 60);
            this.bttn_stergere_angajat.TabIndex = 10;
            this.bttn_stergere_angajat.Text = "Stergere Task";
            this.bttn_stergere_angajat.UseVisualStyleBackColor = true;
            this.bttn_stergere_angajat.Click += new System.EventHandler(this.bttn_stergere_angajat_Click);
            // 
            // bttn_rm_event
            // 
            this.bttn_rm_event.Location = new System.Drawing.Point(366, 512);
            this.bttn_rm_event.Name = "bttn_rm_event";
            this.bttn_rm_event.Size = new System.Drawing.Size(157, 60);
            this.bttn_rm_event.TabIndex = 10;
            this.bttn_rm_event.Text = "Stergere Eveniment";
            this.bttn_rm_event.UseVisualStyleBackColor = true;
            this.bttn_rm_event.Click += new System.EventHandler(this.bttn_rm_event_Click);
            // 
            // EmpSky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1659, 841);
            this.Controls.Add(this.bttn_rm_event);
            this.Controls.Add(this.bttn_stergere_angajat);
            this.Controls.Add(this.Add_Event);
            this.Controls.Add(this.Add_Task);
            this.Controls.Add(this.Ang_Up);
            this.Controls.Add(this.calendarulPeLuna);
            this.Controls.Add(this.Date_task);
            this.Controls.Add(this.Id_Dep);
            this.Controls.Add(this.Del_Emp);
            this.Controls.Add(this.Add_Emp);
            this.Controls.Add(this.Ang_ls);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmpSky";
            this.Text = "EmpSky";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Ang_ls;
        private System.Windows.Forms.Button Add_Emp;
        private System.Windows.Forms.Button Del_Emp;
        private System.Windows.Forms.ListBox Id_Dep;
        private System.Windows.Forms.ListBox Date_task;
        private System.Windows.Forms.MonthCalendar calendarulPeLuna;
        private System.Windows.Forms.Button Ang_Up;
        private System.Windows.Forms.Button Add_Task;
        private System.Windows.Forms.Button Add_Event;
        private System.Windows.Forms.Button bttn_stergere_angajat;
        private System.Windows.Forms.Button bttn_rm_event;
    }
}

