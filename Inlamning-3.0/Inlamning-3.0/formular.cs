using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlamning_3._0
{
    public partial class formular : Form
    {
        public formular()
        {
            InitializeComponent();


        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            information person = new information(tbxFirstName.Text, tbxSurName.Text, long.Parse(tbxSocialSecurityNumber.Text), "", "");//  skapar ett objekt av klassen information, skickar med information som användaren skriver in 
            
            if (person.checkPNr == "Personnumret stämmer") // om resultatet visar rätt värde från objektet så skrivs värdena från objektet ut
            { 
                tbxResults.Text = "Resultat:" + Environment.NewLine + "Förnamn: " + person.firstName + Environment.NewLine + "Efternamn : " + person.surName + Environment.NewLine + "Personnummer : " + person.socialnumber + Environment.NewLine + "Kön : " + person.byGender + Environment.NewLine + person.checkPNr;
            }
           
            else

            {
                tbxResults.Text = "Resultat:"+ Environment.NewLine + "Personnumret stämmer inte, försök igen!"; // annars om värdena inte stämmer skrivs detta felmeddelande ut
            }
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vill du avsluta programmet ?", "Avsluta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit(); // knappen aktiverar ett popup fönster som har olika valmöjligheter klickar man på yes kommer applikationen avslutas annars köras vidare.
                                    // klicket självaste eventet det händelsen som sker när man klickar på knappen
            }
        }

        private void startsidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formular = new Form1();
            formular.ShowDialog();
            this.Close();
        }
    }
}
