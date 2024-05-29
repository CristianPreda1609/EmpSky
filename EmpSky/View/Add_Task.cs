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
    public partial class Add_Task : Form
    {
        private List<Angajat> listaAngajati;
        private int indexAngajatSelectat;
        public Add_Task(List<Angajat> angajati, int indexAngajat)
        {
            InitializeComponent();
            listaAngajati = angajati;
            indexAngajatSelectat = indexAngajat;
        }

        private void Descriere_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Data_Limita_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salvare_Click(object sender, EventArgs e)
        {
            if (indexAngajatSelectat != -1)
            {
                Angajat angajatSelectat = listaAngajati[indexAngajatSelectat];

                string descriereTask = Descriere_Text.Text;
                DateTime dataLimitaTask = DateTime.Parse(Data_Limita_Text.Text);
                int scorTask = 0;

                db_functions fc = new db_functions();
                fc.add_task(angajatSelectat,descriereTask,dataLimitaTask,scorTask);
            }
            this.Close();

        }

        

    }
}
