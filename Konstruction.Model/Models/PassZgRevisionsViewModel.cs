using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class PassZgRevisionsViewModel
    {
        public List<PassZgRevisionViewModel> Source { get; set; }
        public int Parent { get; set; }

        public PassZgRevisionsViewModel()
        {
            Source = new List<PassZgRevisionViewModel>();
        }
    }

}
