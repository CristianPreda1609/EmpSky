
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace EmpSky.Controller
{
    internal class db_functions
    {
        public db_functions() { 
        }

        internal void insert_emp(List<Angajat> listaAngajati)
        {
            listaAngajati.Clear();
            using (EmployeesEntities db = new EmployeesEntities())
            {
                foreach (Angajati ang in db.Angajatis)
                {
                    string nume = ang.Nume;
                    string prenume = ang.Prenume;
                    int id = ang.Id;
                    string departament = ang.Departament;
                    Angajat angajat = new Angajat(nume, prenume, id, departament);

                    foreach (Taskuri taskElement in db.Taskuris.Where((x) => x.AngajatId == ang.Id).ToList())
                    {
                        string descriereTask = taskElement.Descriere;
                        DateTime dataLimitaTask = taskElement.DataLimita.Value;
                        int scorTask = taskElement.Scor.Value;
                        Task task = new Task(descriereTask, dataLimitaTask, scorTask);
                        angajat.ListaTaskuri.Add(task);
                    }

                    foreach (EvenimenteCalendar evenimentElement in db.EvenimenteCalendars.Where((x) => x.AngajatId == ang.Id).ToList())
                    {
                        string descriereEveniment = evenimentElement.Descriere;
                        DateTime dataOraEveniment = evenimentElement.DataOra.Value;
                        EvenimentCalendar eveniment = new EvenimentCalendar(descriereEveniment, dataOraEveniment);
                        angajat.ListaEvenimente.Add(eveniment);
                    }

                    listaAngajati.Add(angajat);
                }
            }
        }

        internal void add_emp(string nume, string prenume, string departament)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                Angajati newAng = new Angajati
                {
                    Nume = nume,
                    Prenume = prenume,
                    Departament = departament

                };
                db.Angajatis.Add(newAng);
                db.SaveChanges();
            }
        }

        internal void rm_emp(int employeeIdToRemove)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                Angajati employeeToRemove = db.Angajatis.FirstOrDefault(x => x.Id == employeeIdToRemove);

                if (employeeToRemove != null)
                {
                    db.Angajatis.Remove(employeeToRemove);

                    db.SaveChanges();
                }
            }
        }
        
        internal void add_event(Angajat ang, string desc, DateTime data_ev)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                EvenimenteCalendar newEveniment = new EvenimenteCalendar
                {
                    AngajatId = ang.Id,
                    Descriere = desc,
                    DataOra = data_ev
                };

                db.EvenimenteCalendars.Add(newEveniment);

                db.SaveChanges();
            }
        }
        internal void add_task(Angajat ang, string desc, DateTime data_lim,int scor)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                Taskuri newTask = new Taskuri
                {
                    AngajatId = ang.Id,
                    Descriere = desc,
                    DataLimita = data_lim,
                    Scor = scor
                };

                db.Taskuris.Add(newTask);

                db.SaveChanges();
            }
        }
        internal void rm_task(Angajat ang, string desc, DateTime data_lim, int scor)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                Taskuri uptask = db.Taskuris.Where((x) => x.AngajatId == ang.Id && x.Descriere == desc && x.DataLimita == data_lim).FirstOrDefault();
                db.Taskuris.Remove(uptask);
                db.SaveChanges();
            }
        }
        internal void rm_event(Angajat ang, string desc, DateTime data_ev)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                EvenimenteCalendar upevent = db.EvenimenteCalendars
                    .Where(x => x.AngajatId == ang.Id && x.Descriere == desc && x.DataOra == data_ev)
                    .FirstOrDefault();
                db.EvenimenteCalendars.Remove(upevent);    
                db.SaveChanges();
            }
        }




    }
}
