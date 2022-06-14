using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class KundeZuweisungZsbsNrViewModel
    {
        public List<KundeZuweisungZsbNrViewModel> Source { get; set; }
        public int Parent { get; set; }

        public KundeZuweisungZsbsNrViewModel()
        {
            Source = new List<KundeZuweisungZsbNrViewModel>();
        }
    }

}
