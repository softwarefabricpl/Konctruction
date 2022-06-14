using Konstruction.Model.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class KundenTeileNrFormViewModel
    {
        public string SessionKey { get; set; }
        public int ID { get; set; }

        [Required(ErrorMessage = "Kunden Zg Nr ist erforderlich")]
        [StringLength(18)]
        public string KZgNr { get; set; }

        [StringLength(18)]
        public string PassPdbNr { get; set; }

        [StringLength(70)]
        public string KZgBz { get; set; }
        public DateTime? KZgDate { get; set; }
        [StringLength(50)]
        public string Datenformat { get; set; }

        [StringLength(5)]
        public string Pdastand { get; set; }
        public string Ersteller { get; set; }
        public string ZgMemo { get; set; }
        public UserInfo UserInfo { get; set; }
        public DateTime? AssignedOn { get; set; }
        public string AssignedTo { get; set; }

    }
}
