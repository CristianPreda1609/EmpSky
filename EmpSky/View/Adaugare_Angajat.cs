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
    public partial class Adaugare_Angajat : Form
    {
        public Adaugare_Angajat()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nume_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prenume_Titlu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Prenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void Id_Titlu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Departament_Titlu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Departament_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salvare_Click(object sender, EventArgs e)
        {

            string nume = Nume.Text;
            string prenume = Prenume.Text;
            string departament = Departament.Text;
            db_functions fct = new db_functions();
            fct.add_emp(nume, prenume, departament);    

            MessageBox.Show("Angajatul a fost adăugat cu succes", "Confirmare", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
