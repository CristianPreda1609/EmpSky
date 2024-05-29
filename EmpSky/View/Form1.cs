using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Contexts;

using EmpSky.Controller;

namespace EmpSky
{
    public partial class EmpSky : Form
    {
        private List<Angajat> listaAngajati = new List<Angajat>();
        public EmpSky()
        {
            InitializeComponent();
            IncarcaAngajati();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void IncarcaAngajati()
        {
            
            listaAngajati.Clear();
            db_functions fct = new db_functions();
            fct.insert_emp(listaAngajati);
            foreach (var angajat in listaAngajati)
            {
                Ang_ls.Items.Add($"{angajat.Nume} {angajat.Prenume} ");//- ID: {angajat.Id} - Departament: {angajat.Departament}
            }
        }
        private void ActualizeazaListBox()
        {
            Ang_ls.Items.Clear();
            IncarcaAngajati();
        }

        private void Add_Emp_Click(object sender, EventArgs e)
        {
            Adaugare_Angajat adaugare_a = new Adaugare_Angajat();
            adaugare_a.FormClosed += AdaugareAngajatInchis;
            adaugare_a.Show();
        }
        private void AdaugareAngajatInchis(object sender, FormClosedEventArgs e)
        {
            ActualizeazaListBox();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            int indexSelectat = Ang_ls.SelectedIndex;

            ActualizeazaCalendarul();
            Angajat angajatSelectat = listaAngajati[indexSelectat];
            Id_Dep.Items.Clear();
            Date_task.Items.Clear();
            if (angajatSelectat.ListaTaskuri.Count > 0)
            {
                foreach (var task in angajatSelectat.ListaTaskuri)
                {
                    string taskDetails = $"Task: {task.Descriere}, Data Limita: {task.DataLimita}";
                    Date_task.Items.Add(taskDetails);
                }
            }
            else
            {
                Date_task.Items.Add("Angajatul nu are task-uri.");
            }
            if (angajatSelectat.ListaEvenimente.Count > 0)
            {
                foreach (var ev in angajatSelectat.ListaEvenimente)
                {
                    string eventDetails = $"Eveniment: {ev.Descriere}, Data: {ev.DataOra}";
                    Date_task.Items.Add(eventDetails);
                }
            }
            else
            {
                Date_task.Items.Add("Angajatul nu are evenimente-uri.");
            }
            Id_Dep.Items.Add($"ID: {angajatSelectat.Id} - Departament: {angajatSelectat.Departament}");//- ID: {angajat.Id} - Departament: {angajat.Departament}
 
        }

        private void AdaugaTaskuriInCalendar()
        {
            if (Ang_ls.SelectedIndex != -1)
            {
                Angajat angajatSelectat = listaAngajati[Ang_ls.SelectedIndex];


                foreach (var task in angajatSelectat.ListaTaskuri)
                {
                    calendarulPeLuna.AddBoldedDate(task.DataLimita.Date);
                }

                calendarulPeLuna.UpdateBoldedDates();
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un angajat din listă.", "Alegere angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AdaugaEvenimenteInCalendar()
        {
            if (Ang_ls.SelectedIndex != -1)
            {
                Angajat angajatSelectat = listaAngajati[Ang_ls.SelectedIndex];

                foreach (var task in angajatSelectat.ListaEvenimente)
                {
                    calendarulPeLuna.AddBoldedDate(task.DataOra.Date);
                    calendarulPeLuna.TitleBackColor = System.Drawing.Color.Red;
                }

                calendarulPeLuna.UpdateBoldedDates();
            }
            else
            {
   
                MessageBox.Show("Vă rugăm să selectați un angajat din listă.", "Alegere angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizeazaCalendarul()
        {

            calendarulPeLuna.RemoveAllBoldedDates();
            AdaugaTaskuriInCalendar();
            AdaugaEvenimenteInCalendar();
        }

        private void Add_Task_Click(object sender, EventArgs e)
        {
            if (Ang_ls.SelectedIndex != -1)
            {
                int indexSelectat = Ang_ls.SelectedIndex;
                Add_Task addTaskForm = new Add_Task(listaAngajati, indexSelectat);
                addTaskForm.FormClosed += AdaugareTaskInchis;
                addTaskForm.Show();
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un angajat din listă.", "Alegere angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AdaugareTaskInchis(object sender, FormClosedEventArgs e)
        {
            int indexSelectat = Ang_ls.SelectedIndex;
            calendarulPeLuna.RemoveAllBoldedDates();
            listaAngajati.Clear();
            Ang_ls.Items.Clear();
            IncarcaAngajati();
            AdaugaTaskuriInCalendar();
            AdaugaEvenimenteInCalendar();



            ActualizeazaCalendarul();
            Angajat angajatSelectat = listaAngajati[indexSelectat];
            Id_Dep.Items.Clear();
            Date_task.Items.Clear();
            if (angajatSelectat.ListaTaskuri.Count > 0)
            {
                foreach (var task in angajatSelectat.ListaTaskuri)
                {
                    string taskDetails = $"Task: {task.Descriere}, Data Limita: {task.DataLimita}";
                    Date_task.Items.Add(taskDetails);
                }
            }
            else
            {
                Date_task.Items.Add("Angajatul nu are task-uri.");
            }
            if (angajatSelectat.ListaEvenimente.Count > 0)
            {
                foreach (var ev in angajatSelectat.ListaEvenimente)
                {
                    string eventDetails = $"Eveniment: {ev.Descriere}, Data: {ev.DataOra}";
                    Date_task.Items.Add(eventDetails);
                }
            }
            else
            {
                Date_task.Items.Add("Angajatul nu are evenimente-uri.");
            }
            Id_Dep.Items.Add($"ID: {angajatSelectat.Id} - Departament: {angajatSelectat.Departament}");//- ID: {angajat.Id} - Departament: {angajat.Departament}
        }

        private void AdaugareUpInchis(object sender, EventArgs e)
        {
            listaAngajati.Clear();
            Ang_ls.Items.Clear();
            IncarcaAngajati();
            calendarulPeLuna.RemoveAllBoldedDates();
            Id_Dep.Items.Clear();
            Date_task.Items.Clear();
        }
        private void Ang_Up_Click(object sender, EventArgs e)
        {
            if (Ang_ls.SelectedIndex != -1)
            {
                int indexSelectat = Ang_ls.SelectedIndex;
            Update_Emp updateEmpForm = new Update_Emp(listaAngajati, indexSelectat);
            updateEmpForm.FormClosed += AdaugareUpInchis;
            updateEmpForm.Show();
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un angajat din listă.", "Alegere angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Add_Event_Click(object sender, EventArgs e)
        {
            if (Ang_ls.SelectedIndex != -1)
            {
                int indexSelectat = Ang_ls.SelectedIndex;
                Add_Event addEventForm = new Add_Event(listaAngajati, indexSelectat);
                addEventForm.FormClosed += AdaugareEventInchis;
                addEventForm.Show();
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un angajat din listă.", "Alegere angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AdaugareEventInchis(object sender, FormClosedEventArgs e)
        {
            int indexSelectat = Ang_ls.SelectedIndex;
            calendarulPeLuna.RemoveAllBoldedDates();
            listaAngajati.Clear();
            Ang_ls.Items.Clear();
            IncarcaAngajati();
            AdaugaTaskuriInCalendar();
            AdaugaEvenimenteInCalendar();


            ActualizeazaCalendarul();
            Angajat angajatSelectat = listaAngajati[indexSelectat];
            Id_Dep.Items.Clear();
            Date_task.Items.Clear();
            if (angajatSelectat.ListaTaskuri.Count > 0)
            {
                foreach (var task in angajatSelectat.ListaTaskuri)
                {
                    string taskDetails = $"Task: {task.Descriere}, Data Limita: {task.DataLimita}";
                    Date_task.Items.Add(taskDetails);
                }
            }
            else
            {
                Date_task.Items.Add("Angajatul nu are task-uri.");
            }
            if (angajatSelectat.ListaEvenimente.Count > 0)
            {
                foreach (var ev in angajatSelectat.ListaEvenimente)
                {
                    string eventDetails = $"Eveniment: {ev.Descriere}, Data: {ev.DataOra}";
                    Date_task.Items.Add(eventDetails);
                }
            }
            else
            {
                Date_task.Items.Add("Angajatul nu are evenimente-uri.");
            }
            Id_Dep.Items.Add($"ID: {angajatSelectat.Id} - Departament: {angajatSelectat.Departament}");//- ID: {angajat.Id} - Departament: {angajat.Departament}
            
        }

        private void Del_Emp_Click(object sender, EventArgs e)
        {
            if (Ang_ls.SelectedIndex != -1)
            {
                int indexSelectat = Ang_ls.SelectedIndex;
                int employeeIdToRemove = listaAngajati[indexSelectat].Id;
                db_functions fct = new db_functions();
                fct.rm_emp(employeeIdToRemove);
                IncarcaAngajati();
                Ang_ls.Items.Clear();
                ActualizeazaListBox();
                Id_Dep.Items.Clear();
                Date_task.Items.Clear();
                calendarulPeLuna.RemoveAllBoldedDates();


            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un angajat din listă.", "Alegere angajat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bttn_stergere_angajat_Click(object sender, EventArgs e)
        {
            if (Ang_ls.SelectedIndex != -1)
            {
                int index1 = Date_task.SelectedIndex;
                Angajat angajatSelectat = listaAngajati[Ang_ls.SelectedIndex];
                db_functions f = new db_functions();
                f.rm_task(angajatSelectat, angajatSelectat.ListaTaskuri[index1].Descriere, angajatSelectat.ListaTaskuri[index1].DataLimita, angajatSelectat.ListaTaskuri[index1].Scor);
                AdaugareTaskInchis(this, null);
            }
        }

        private void bttn_rm_event_Click(object sender, EventArgs e)
        {
            if (Ang_ls.SelectedIndex != -1)
            {
                int index2 = Date_task.SelectedIndex;
                int cont = 1;
                Angajat angajatSelectat = listaAngajati[Ang_ls.SelectedIndex];
                index2--;
                foreach (var task in angajatSelectat.ListaTaskuri)
                {
                    if(cont  == 1)
                    {
                        index2++;
                        cont--;
                    }

                    index2--;
                }


                db_functions f = new db_functions();
                f.rm_event(angajatSelectat, angajatSelectat.ListaEvenimente[index2].Descriere, angajatSelectat.ListaEvenimente[index2].DataOra);
                AdaugareTaskInchis(this, null);


            }
        }

        private void Date_task_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
