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
    public partial class Add_Event : Form
    {
        private List<Angajat> listaAngajati;
        private int indexAngajatSelectat;
        public Add_Event(List<Angajat> angajati, int indexAngajat)
        {
            InitializeComponent();
            listaAngajati = angajati;
            indexAngajatSelectat = indexAngajat;
        }
       

        private void Descriere_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_Text_TextChanged(object sender, EventArgs e)
        {

        }
        private void Salvare_Click_1(object sender, EventArgs e)
        {
            if (indexAngajatSelectat != -1)
            {
                Angajat angajatSelectat = listaAngajati[indexAngajatSelectat];

                string descriereEveniment = Descriere_Text.Text;
                DateTime dataEveniment = DateTime.Parse(Data_Text.Text);

               db_functions fc = new db_functions();
                fc.add_event(angajatSelectat,descriereEveniment, dataEveniment);


            }
            this.Close();
        }

        
        
    }
}
