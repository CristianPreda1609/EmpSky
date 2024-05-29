
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmpSky.Controller
{
    internal class updateang
    {
        internal void update_ang_nume(Angajat ang, string nume)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                Angajati upang = db.Angajatis.Where((x) => x.Id == ang.Id).FirstOrDefault();
                if (upang != null)
                {
                    upang.Nume = nume;

                    db.SaveChanges();
                }
            }
        }

        internal void update_ang_prenume(Angajat ang, string prenume)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                Angajati upang = db.Angajatis.Where((x) => x.Id == ang.Id).FirstOrDefault();
                if (upang != null)
                {
                    upang.Prenume = prenume;

                    db.SaveChanges();
                }
            }
        }
        internal void update_ang_desc(Angajat ang, string dep)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                Angajati upang = db.Angajatis.Where((x) => x.Id == ang.Id).FirstOrDefault();
                if (upang != null)
                {
                    upang.Departament = dep;

                    db.SaveChanges();
                }
            }
        }
        internal void update_task(Angajat ang, string desc_f, DateTime datalim_f,string desc, DateTime datalim, int scor)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                Taskuri uptask = db.Taskuris.Where((x)=> x.AngajatId == ang.Id && x.Descriere == desc_f && x.DataLimita == datalim_f).FirstOrDefault();
                if(uptask != null)
                {
                    uptask.Descriere = desc;
                    uptask.DataLimita = datalim;
                    uptask.Scor=scor;
                    db.SaveChanges();
                }
            }
        }

        internal void update_event(Angajat ang, string desc_first, DateTime data_first,string desc, DateTime data)
        {
            using (EmployeesEntities db = new EmployeesEntities())
            {
                EvenimenteCalendar upevent = db.EvenimenteCalendars
                    .Where(x => x.AngajatId == ang.Id && x.Descriere == desc_first && x.DataOra == data_first)
                    .FirstOrDefault();

                if (upevent != null)
                {
                    upevent.Descriere = desc;
                    upevent.DataOra = data;
                    db.SaveChanges();
                }
            }
        }

    }
}
