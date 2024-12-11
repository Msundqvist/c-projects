namespace Inlamning_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void registreraAnvändareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // gömmer första formen för att sedan öppna nya formuläret som sedan stänger ner första formen
            Form meny = new formular(); 
            meny.ShowDialog(); 
            this.Close();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vill du avsluta programmet ?", "Avsluta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit(); // knappen aktiverar ett popup fönster som har olika valmöjligheter klickar man på yes kommer applikationen avslutas annars köras vidare.
                                    // klicket självaste eventet det händelsen som sker när man klickar på knappen
            }
        }
    }
}