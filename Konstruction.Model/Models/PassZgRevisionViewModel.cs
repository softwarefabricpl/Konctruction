using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class PassZgRevisionViewModel
    {
        public int ID { get; set; }

        public string RevRecord { get; set; }
        public DateTime? RevDate { get; set; }
        public string Action { get; set; }
    }

}
