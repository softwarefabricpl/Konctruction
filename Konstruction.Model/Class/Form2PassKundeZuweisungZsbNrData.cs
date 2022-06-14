using Konstruction.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Class
{
    public class Form2PassKundeZuweisungZsbNrData
    {
        public string Key { get; set; }
        public List<PassKundeZuweisungZsbNrViewModel> PassKundeZuweisungZsbNrData { get; set; }
        
        public Form2PassKundeZuweisungZsbNrData()
        {
            PassKundeZuweisungZsbNrData = new List<PassKundeZuweisungZsbNrViewModel>();
        }
    }

}
