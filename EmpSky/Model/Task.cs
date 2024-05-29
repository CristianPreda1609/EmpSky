using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSky
{
    public class Task
    {
        public string Descriere { get; set; }
        public DateTime DataLimita { get; set; }
        public int Scor { get; set; }

        public Task( string descriere, DateTime dataLimita, int scor)
        {

            Descriere = descriere;
            DataLimita = dataLimita;
            Scor = scor;
        }
    }

}
