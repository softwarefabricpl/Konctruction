using Konstruction.Model.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class PassTeileNrFormViewModel
    {
        public string SessionKey { get; set; }
        public int ID { get; set; }

        [Required(ErrorMessage = "Pass Zg Nr ist erforderlich")]
        [StringLength(18)]
        public string ZgNr { get; set; }

        [StringLength(70)]
        public string Bezeichnung { get; set; }

        public DateTime? Datensatz { get; set; }

        [StringLength(50)]
        public string Datenformat { get; set; }
        public string Bemerkung { get; set; }
        public UserInfo UserInfo { get; set; }
        public DateTime? AssignedOn { get; set; }
        public string AssignedTo { get; set; }

        [StringLength(18)]
        public string PassPdbNr { get; set; }
        [StringLength(20)]
        public string CustomerNumber { get; set; }
    }

}
