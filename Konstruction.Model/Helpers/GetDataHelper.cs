using Konstruction.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruction.Model.Helpers
{
    public class GetDataHelper
    {
  
        public static List<PassTeileNrViewModel> GetPassTeileNrItems()
        {
            List<PassTeileNrViewModel> result = new List<PassTeileNrViewModel>();

            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Pass_Teile_nr.AsNoTracking()
                          select new PassTeileNrViewModel
                          {
                              ID = l.ID,
                              Bezeichnung = l.p_zg_bz,
                              Datenformat = l.data_format,
                              Bemerkung = l.p_zg_memo,
                              PassPdbNr = l.PassPdbNr,
                              Datensatz = l.p_zg_date,
                              ZgNr = l.p_zg_nr,
                              CustomerNumber=l.Customer_Number
                          }).ToList();

            }

            return result;
        }

        public static List<KundenTeileNrViewModel> GetKundenTeileNrItems()
        {
            List<KundenTeileNrViewModel> result = new List<KundenTeileNrViewModel>();

            using (var db = new KonstructionEntities())
            {
                result = (from l in db.Kunden_Teile_nr.AsNoTracking()
                          select new KundenTeileNrViewModel
                          {
                              ID = l.ID,
                              KZgBz = l.k_zg_bz,
                              Datenformat = l.data_format,
                              Ersteller = l.Ersteller,
                              Pdastand = l.k_pda_stand,
                              KZgDate = l.k_zg_date,
                              ZgMemo = l.k_zg_memo,
                              KZgNr = l.k_zg_nr,
                              PassPdbNr = l.PassPdbNr
                          }).ToList();

            }

            return result;
        }
    }
}
