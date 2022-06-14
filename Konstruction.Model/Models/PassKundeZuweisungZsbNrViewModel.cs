using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class PassKundeZuweisungZsbNrViewModel
    {
        [Required]
        public int PassKundezuweisungZSBNr
        {
            get; set;

        }

        public string Action { get; set; }
        public int ID { get; set; }
    }

}
