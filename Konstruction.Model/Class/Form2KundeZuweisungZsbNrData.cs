using Konstruction.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Class
{
    public class Form2KundeZuweisungZsbNrData
    {
        public string Key { get; set; }
        public List<KundeZuweisungZsbNrViewModel> KundeZuweisungZsbNrData { get; set; }
        
        public Form2KundeZuweisungZsbNrData()
        {
            KundeZuweisungZsbNrData = new List<KundeZuweisungZsbNrViewModel>();
        }
    }

}
