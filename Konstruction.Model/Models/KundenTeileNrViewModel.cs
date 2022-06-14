using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class KundenTeileNrViewModel
    {
        public int? ID { get; set; }
        public string KZgNr { get; set; }
        public string KZgBz { get; set; }
        public DateTime? KZgDate { get; set; }
        public string Datenformat { get; set; }
        public string Pdastand { get; set; }
        public string Ersteller { get; set; }
        public string ZgMemo { get; set; }
        public string PassPdbNr { get; set; }

    }

}
