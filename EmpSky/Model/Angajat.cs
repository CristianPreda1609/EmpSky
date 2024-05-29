using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace EmpSky
{
    public class Angajat
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Id { get; set; }
        public string Departament { get; set; }
        public List<Task> ListaTaskuri { get; set; }
        public List<EvenimentCalendar> ListaEvenimente { get; set; }



        public Angajat(string nume,string prenume, int id, string departament)
        {
            Nume = nume;
            Prenume = prenume;
            Id = id;
            Departament = departament;
            ListaTaskuri = new List<Task>();
            ListaEvenimente = new List<EvenimentCalendar>();
        }

       
    }
}
