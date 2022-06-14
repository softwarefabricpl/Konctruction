using Konstruction.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Class
{
    public class Form2KundeZgRevisioNrData
    {
        public string Key { get; set; }
   
        public List<KundeZgRevisionViewModel> KundeZgRevisionData { get; set; }
        
        public Form2KundeZgRevisioNrData()
        {
            KundeZgRevisionData = new List<KundeZgRevisionViewModel>();
        }
    }
}
