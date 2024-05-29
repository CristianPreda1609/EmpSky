using EmpSky.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmpSky
{
    public partial class Update_Emp : Form
    {
        private List<Angajat> listaAngajati;
        private int indexAngajatSelectat;
        public Update_Emp(List<Angajat> angajati, int indexAngajat)
        {
            InitializeComponent();
            listaAngajati = angajati;
            indexAngajatSelectat = indexAngajat;
            Update_Emp_Load();
        }
        private void Update_Emp_Load()
        {
            listaAngajati.Clear();
            db_functions fc = new db_functions();
            fc.insert_emp(listaAngajati);
            if (indexAngajatSelectat >= 0 && indexAngajatSelectat < listaAngajati.Count)
            {
                Angajat angajatSelectat = listaAngajati[indexAngajatSelectat];

                Nume.Text = "Nume: " + angajatSelectat.Nume;
                Prenume.Text = "Prenume: " + angajatSelectat.Prenume;
                Id.Text = "ID: " + angajatSelectat.Id.ToString();
                Departament.Text = "Departament: " + angajatSelectat.Departament;
                listTask.Items.Clear();
                if (angajatSelectat.ListaTaskuri.Count > 0)
                {
                    foreach (var task in angajatSelectat.ListaTaskuri)
                    {
                        listTask.Items.Add($"Task: {task.Descriere}  Data Limita:{task.DataLimita}  Scor: {task.Scor}");
                    }
                }
                else
                {
                    listTask.Items.Add("Angajatul nu are task-uri.");
                }
                listEvent.Items.Clear();    
                if (angajatSelectat.ListaEvenimente.Count > 0)
                {
                    foreach (var ev in angajatSelectat.ListaEvenimente)
                    {
                        listEvent.Items.Add($"Eveniment:{ev.Descriere} Data: {ev.DataOra} ");
                    }
                }
                else
                {
                    listEvent.Items.Add("Angajatul nu are evenimente-uri.");
                }
            }
            else
            {
                MessageBox.Show("Indexul angajatului selectat nu este valid.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); 
            }
        }
        private void Salvare_Nume_Click(object sender, EventArgs e)
        {
            Angajat angajatSelectat = listaAngajati[indexAngajatSelectat];
            updateang f = new updateang();
            f.update_ang_nume(angajatSelectat, text_box_Nume.Text.Trim());

            MessageBox.Show("Numele angajatului a fost salvat.", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Update_Emp_Load();

        }

        private void Salvare_Prenume_Click(object sender, EventArgs e)
        {
            Angajat angajatSelectat = listaAngajati[indexAngajatSelectat];
            updateang f = new updateang();
            f.update_ang_prenume(angajatSelectat, text_box_Prenume.Text.Trim());

            MessageBox.Show("Prenumele angajatului a fost salvat.", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Update_Emp_Load();

        }

        private void Salvare_Departament_Click(object sender, EventArgs e)
        {

            Angajat angajatSelectat = listaAngajati[indexAngajatSelectat];
            updateang f = new updateang();
            f.update_ang_desc(angajatSelectat, text_box_Departament.Text.Trim());

            MessageBox.Show("Departamentul angajatului a fost salvat.", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Update_Emp_Load();

        }

        private void Salvare_task_Click(object sender, EventArgs e)
        {
            if (indexAngajatSelectat != -1)
            {
                int index1 = listTask.SelectedIndex;
                Angajat angajatSelectat = listaAngajati[indexAngajatSelectat];
                updateang f = new updateang();

                string descriereTask = Descriere_task.Text;
                DateTime dataLimitaTask = DateTime.Parse(Data_task.Text);
                int scorTask = int.Parse(Scor_task.Text);

                    
                f.update_task(angajatSelectat, angajatSelectat.ListaTaskuri[index1].Descriere, angajatSelectat.ListaTaskuri[index1].DataLimita,descriereTask, dataLimitaTask, scorTask);


                Update_Emp_Load();


;
                MessageBox.Show("Task-ul angajatului a fost salvat.", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
        }

        private void Salvare_Event_Click(object sender, EventArgs e)
        {
            if (indexAngajatSelectat != -1)
            {
                int index2 = listEvent.SelectedIndex;
                Angajat angajatSelectat = listaAngajati[indexAngajatSelectat];
                updateang f = new updateang();

                string descriereEveniment = Descriere_event.Text;
                DateTime dataEveniment = DateTime.Parse(Data_event.Text);
                EvenimentCalendar eveniment = new EvenimentCalendar(descriereEveniment, dataEveniment);

                if (eveniment != null)
                {

                    f.update_event(angajatSelectat,angajatSelectat.ListaEvenimente[index2].Descriere, angajatSelectat.ListaEvenimente[index2].DataOra, descriereEveniment, dataEveniment);
                    Update_Emp_Load();
                }

            


                


                Update_Emp_Load();
                MessageBox.Show("Evenimentul angajatului a fost salvat.", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();
            }
        }

        private void Nume_Click(object sender, EventArgs e)
        {

        }

        private void Prenume_Click(object sender, EventArgs e)
        {

        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void Departament_Click(object sender, EventArgs e)
        {

        }

        private void Descriere_event_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
