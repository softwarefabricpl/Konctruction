using Konstruction.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Class
{
    public class Form1PassZgRevisioNrData
    {
        public string Key { get; set; }
   
        public List<PassZgRevisionViewModel> PassZgRevisionData { get; set; }
        
        public Form1PassZgRevisioNrData()
        {
            PassZgRevisionData = new List<PassZgRevisionViewModel>();
        }
    }
}
