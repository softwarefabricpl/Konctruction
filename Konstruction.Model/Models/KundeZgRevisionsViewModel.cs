using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class KundeZgRevisionsViewModel
    {
        public List<KundeZgRevisionViewModel> Source { get; set; }
        public int Parent { get; set; }

        public KundeZgRevisionsViewModel()
        {
            Source = new List<KundeZgRevisionViewModel>();
        }
    }

}
