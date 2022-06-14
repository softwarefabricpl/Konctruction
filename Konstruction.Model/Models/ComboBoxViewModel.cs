using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Models
{
    public class ComboBoxViewModel
    {
        public string Name { get; set; }
        public int? ID { get; set; }
    }

    public class PassKundeZuweisungZSBNrComboBoxView
    {
        public string p_zg_nr { get; set; }
        public int? ID { get; set; }
        public PassKundeZuweisungZSBNrComboBoxView( )
        {
 
        }
        public PassKundeZuweisungZSBNrComboBoxView(Pass_Teile_nr model)
        {
            ID = model.ID;
            p_zg_nr = model.p_zg_nr;
        }
    }
    public class KundeZuweisungZSBNrComboBoxView
    {
        public string k_zg_nr { get; set; }
        public int? ID { get; set; }
        public KundeZuweisungZSBNrComboBoxView()
        {

        }
        public KundeZuweisungZSBNrComboBoxView(Kunden_Teile_nr model)
        {
            ID = model.ID;
            k_zg_nr = model.k_zg_nr;
        }
    }

    public class PasszuweisungZSBNrComboBoxView
    {
        public string p_zg_nr { get; set; }
        public int? ID { get; set; }
        public PasszuweisungZSBNrComboBoxView()
        {

        }
        public PasszuweisungZSBNrComboBoxView(Pass_Teile_nr model)
        {
            ID = model.ID;
            p_zg_nr = model.p_zg_nr;
        }
    }
}
