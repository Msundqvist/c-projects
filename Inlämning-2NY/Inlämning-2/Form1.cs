using System.Drawing.Text;
using System.IO;  // include the System.IO namespace

namespace Inlämning_2
{
    public partial class Form1 : Form
    {
        private List<Saljare> saljarlist = new List<Saljare>(); // skapar en lista av klassen säljare
        public Form1()
        {
            InitializeComponent();
        }

        int niva1 = 0; //  int som ligger i global miljö för att sedan köras i respektive if sats
        int niva2 = 0;
        int niva3 = 0;
        int niva4 = 0;
        
        private void btnLaggTill_Click(object sender, EventArgs e)
        {
            
            Saljare saljare = new Saljare();  // skapar ett objekt av klassen säljare till listan

            saljare.namn = tbxNamn.Text;
            saljare.personNummer = long.Parse(tbxPersonNummer.Text);
            saljare.distrikt = tbxDistrikt.Text;
            saljare.antal = int.Parse(tbxAntal.Text);


            if (saljare.antal < 50 ) // om antalet är lägre än 50 blir säljarnivån 1
            {
                saljare.niva = 1;
                niva1 = niva1 + 1; // lägger till antalet säljare i nivån
                
                
            }

            if (saljare.antal >= 50 && saljare.antal < 100)
            {
                saljare.niva = 2;
                niva2 = niva2 + 1;
            }

            if (saljare.antal >= 100 && saljare.antal <= 199)
            {
                saljare.niva = 3;
                niva3 = niva3 + 1;
            }

            if (saljare.antal > 199)
            {
                saljare.niva = 4;
                niva4 = niva4 + 1;
            }
           

            saljarlist.Add(saljare); // lägger till säjaren till listan
            
        }

        private void btnSkrivUt_Click(object sender, EventArgs e) // listan skrivs ut med denna knapp där det delas in i nivåer
        {

            
            tbxResultat.Text = "";
            tbxResultat.AppendText("Nivå 1:" + Environment.NewLine); // skapar rubriken och läggger till ny rad
            
            for (int i = 0; i < saljarlist.Count; i++) // loopar igenom listan för att kolla om värdet på någon nivå är = 1 i så fall skriver den ut i textboxen
            {
                
                if (saljarlist[i].niva == 1 ) // om säljaren sålt under 50 = nivå 1 
                {
                    
                    tbxResultat.AppendText(" Namn: " + saljarlist[i].namn + " Personnummer: " + saljarlist[i].personNummer + " Distrikt: " + saljarlist[i].distrikt + " Antal: " + saljarlist[i].antal + Environment.NewLine );
                    
                }
            }
            tbxResultat.AppendText(niva1 + " säljare i nivå 1" + Environment.NewLine); // skrver ut antal säjare i nivån i textboxen
            tbxResultat.AppendText("Nivå 2:" + Environment.NewLine);

            for (int i = 0; i < saljarlist.Count; i++)
            {
                if (saljarlist[i].niva == 2)
                {
                    tbxResultat.AppendText(" Namn: " + saljarlist[i].namn + " Personnummer: " + saljarlist[i].personNummer + " Distrikt: " + saljarlist[i].distrikt + " Antal: " + saljarlist[i].antal + Environment.NewLine);
                }
            }

            tbxResultat.AppendText(niva2 + " säljare i nivå 2" + Environment.NewLine);
            tbxResultat.AppendText("Nivå 3:" + Environment.NewLine);

            for (int i = 0; i < saljarlist.Count; i++)
            {
                if (saljarlist[i].niva == 3)
                {
                    tbxResultat.AppendText(" Namn: " + saljarlist[i].namn + " Personnummer: " + saljarlist[i].personNummer + " Distrikt: " + saljarlist[i].distrikt + " Antal: " + saljarlist[i].antal + Environment.NewLine);
                }
            }

            tbxResultat.AppendText(niva3 + " säljare i nivå 3" + Environment.NewLine);
            tbxResultat.AppendText("Nivå 4:" + Environment.NewLine);

            for (int i = 0; i < saljarlist.Count; i++)
            {
                if (saljarlist[i].niva == 4)
                {
                    tbxResultat.AppendText(" Namn: " + saljarlist[i].namn + " Personnummer: " + saljarlist[i].personNummer + " Distrikt: " + saljarlist[i].distrikt + " Antal: " + saljarlist[i].antal + Environment.NewLine);
                }
            }
            tbxResultat.AppendText(niva4 + " säljare i nivå 4" + Environment.NewLine);

        }
        
        private void btnSpara_Click(object sender, EventArgs e) // samma funktionalitet som för skriva ut i textblocket men här sparas allt ner till en text string
        {
            
            string textBlock ="";
                textBlock = "Nivå 1: " + Environment.NewLine; 
                for (int i = 0; i < saljarlist.Count; i++) 
                {
                    if (saljarlist[i].niva == 1) 
                    {

                    textBlock = textBlock + " Namn: " + saljarlist[i].namn + " Personnummer: " + saljarlist[i].personNummer + " Distrikt: " + saljarlist[i].distrikt + " Antal: " + saljarlist[i].antal + Environment.NewLine;
                    }
                }

            textBlock = textBlock + niva1 + " säljare i nivå 1 " + Environment.NewLine;
            textBlock = textBlock + "Nivå 2:" + Environment.NewLine; 

            for (int i = 0; i < saljarlist.Count; i++) 
            {
                if (saljarlist[i].niva == 2) 
                {
                    textBlock = textBlock + " Namn: " + saljarlist[i].namn + " Personnummer: " + saljarlist[i].personNummer + " Distrikt: " + saljarlist[i].distrikt + " Antal: " + saljarlist[i].antal + Environment.NewLine;
                }
            }

            textBlock = textBlock + niva2 + " säljare i nivå 2 " + Environment.NewLine; 
            textBlock = textBlock + "Nivå 3:" + Environment.NewLine; 

            for (int i = 0; i < saljarlist.Count; i++) 
            {
                if (saljarlist[i].niva == 3)  
                {
                    textBlock = textBlock + " Namn: " + saljarlist[i].namn + " Personnummer: " + saljarlist[i].personNummer + " Distrikt: " + saljarlist[i].distrikt + " Antal: " + saljarlist[i].antal + Environment.NewLine;
                }
            }

            textBlock = textBlock + niva3 + " säljare i nivå 3 " + Environment.NewLine;
            textBlock = textBlock + "Nivå 4:" + Environment.NewLine; 

            for (int i = 0; i < saljarlist.Count; i++) 
            {
                if (saljarlist[i].niva == 4) 
                {
                    textBlock = textBlock + " Namn: " + saljarlist[i].namn + " Personnummer: " + saljarlist[i].personNummer + " Distrikt: " + saljarlist[i].distrikt + " Antal: " + saljarlist[i].antal + Environment.NewLine;
                }
            }
            textBlock = textBlock + niva4 + " säljare i nivå 4 " + Environment.NewLine;
            File.WriteAllText("filename.txt", textBlock); // sparar ner all text tiill filen 

        }
    }
}