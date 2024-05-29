using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSky
{
    public class EvenimentCalendar
    {
  
        public string Descriere { get; set; }
        public DateTime DataOra { get; set; }

        public EvenimentCalendar( string descriere, DateTime dataOra)
        {
            Descriere = descriere;
            DataOra = dataOra;
        }
    }
}
