namespace Inlamning_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void registreraAnv�ndareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // g�mmer f�rsta formen f�r att sedan �ppna nya formul�ret som sedan st�nger ner f�rsta formen
            Form meny = new formular(); 
            meny.ShowDialog(); 
            this.Close();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vill du avsluta programmet ?", "Avsluta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit(); // knappen aktiverar ett popup f�nster som har olika valm�jligheter klickar man p� yes kommer applikationen avslutas annars k�ras vidare.
                                    // klicket sj�lvaste eventet det h�ndelsen som sker n�r man klickar p� knappen
            }
        }
    }
}