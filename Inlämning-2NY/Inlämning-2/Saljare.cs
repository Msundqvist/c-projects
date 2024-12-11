using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Inlämning_2
{
    public class Saljare
    {
       public string namn = "namn";
       public string distrikt = "distrikt";

       public int antal = 0;             // antal + personummer är i siffror istället för string
       public long personNummer = 0; // krävs fler byte för 10 siffor därför används en long istället för int
       public int niva = 0; // nivå finns för att kunna separera de olika 4 nivåerna då behöver de ha ett utgångsvärde
                           // nivå 1 = 0 till 49, nivå 2 = 50 till 99, nivå 3 = 99 till 199, nivå 4 = 199 och uppåt

    }
}
