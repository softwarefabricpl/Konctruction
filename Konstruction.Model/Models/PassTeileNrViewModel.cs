using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class PassTeileNrViewModel
    {
        public int? ID { get; set; }
        public string Bezeichnung { get; set; }
        public DateTime? Datensatz { get; set; }
        public string Datenformat { get; set; }
        public string Bemerkung { get; set; }
        public string PassPdbNr { get; set; }
        public string ZgNr { get; set; }
        public string CustomerNumber { get; set; }
    }

}
