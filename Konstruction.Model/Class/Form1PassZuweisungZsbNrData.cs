using Konstruction.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Class
{
    public class Form1PassZuweisungZsbNrData
    {
        public string Key { get; set; }
        public List<PassZuweisungZsbNrViewModel> PassZuweisungZsbNrData { get; set; }
        
        public Form1PassZuweisungZsbNrData()
        {
            PassZuweisungZsbNrData = new List<PassZuweisungZsbNrViewModel>();
        }
    }

}
