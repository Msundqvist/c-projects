namespace inlämning1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnKör_Click(object sender, EventArgs e) 
        {
            int attBetala = int.Parse(tbxAttBetala.Text); // den hämtar värdet från textboxen, konventerar från en string (text) till en int (heltat)
            int betalt = int.Parse(tbxBetalt.Text);       // det behövs göras för det inte går att göra beräkningar på en string.
                                                         


            int femhundra = 0;
            int tvåhundra = 0;  //  värdet i boxarna när man klickar är ställ på 0 
            int etthundra = 0;
            int femtio = 0;
            int tjugo = 0;
            int tio = 0;
            int fem = 0;
            int ett = 0;

            int växel = betalt - attBetala; // räknar ut värdet av hur mycket växel som ska betalas tillbaka

            tbx500.Text = string.Empty;
            tbx200.Text = string.Empty; // finns det inget värde i textboxen ska det inte skrivas ut
            tbx100.Text = string.Empty;
            tbx50.Text = string.Empty;
            tbx20.Text = string.Empty;
            tbx10.Text = string.Empty;
            tbx5.Text = string.Empty;
            tbx1.Text = string.Empty;

            if (växel < 0) // om pengarna som sätts i betalt understiger priset man ska betala kör den här funktionen
            {
                MessageBox.Show("Det saknas pengar "); // om det betalts förlite pengar kommer ett popupfönster att man betalat förlite pengar
            }

            if (växel >= 500)    // om det finns växel kommer programmet köra denna if satsen om det finns värde som är större eller lika med 500
            {
                femhundra = växel / 500;   //  dividerar växel med 500 för att se hur många femhundralappar som ska ges tillbaka, när det är en int avrundas den neråt til första heltal
                växel = växel - 500 * femhundra; // subtrahera antalet femhundralappar som ska betalas tillbaka med växel
                tbx500.Text = femhundra.ToString(); // för att kunna skriva ut värdet i texboxen
            }


            if (växel >= 200)
            {
                tvåhundra = växel / 200;
                växel = växel - 200 * tvåhundra;
                tbx200.Text = tvåhundra.ToString();
            }



            if (växel >= 100)
            {
                etthundra = växel / 100;
                växel = växel - 100 * etthundra;
                tbx100.Text = etthundra.ToString();
            }


            if (växel >= 50)
            {
                femtio = växel / 50;
                växel = växel - 50 * femtio;
                tbx50.Text = femtio.ToString();
            }


            if (växel >= 20)
            {
                tjugo = växel / 20;
                växel = växel - 100 * tjugo;
                tbx20.Text = tjugo.ToString();
            }


            if (växel >= 10)
            {
                tio = växel / 10;
                växel = växel - 10 * tio;
                tbx10.Text = tio.ToString();
            }


            if (växel >= 5)
            {
                fem = växel / 5;
                växel = växel - 5 * fem;
                tbx5.Text = fem.ToString();
            }


            if (växel >= 1)
            {
                ett = växel / 1;
                växel = växel - 1 * ett;
                tbx1.Text = ett.ToString();
            }

            lblVäxel.Text = växel.ToString();

        }

        private void btnAvsluta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vill du avsluta programmet ?", "Avsluta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit(); // knappen aktiverar ett popup fönster som har olika valmöjligheter klickar man på yes kommer applikationen avslutas annars köras vidare.
                 // klicket självaste eventet det händelsen som sker när man klickar på knappen
            }
        }
    }
}