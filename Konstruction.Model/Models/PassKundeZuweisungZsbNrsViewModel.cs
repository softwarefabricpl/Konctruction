using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class PassKundeZuweisungZsbNrsViewModel
    {
        public List<PassKundeZuweisungZsbNrViewModel> Source { get; set; }
        public int Parent { get; set; }

        public PassKundeZuweisungZsbNrsViewModel()
        {
            Source = new List<PassKundeZuweisungZsbNrViewModel>();
        }
    }

}
