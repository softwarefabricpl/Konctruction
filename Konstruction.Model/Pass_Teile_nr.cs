//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Konstruction.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pass_Teile_nr
    {
        public string p_zg_nr { get; set; }
        public string p_zg_bz { get; set; }
        public Nullable<System.DateTime> p_zg_date { get; set; }
        public string data_format { get; set; }
        public string p_zg_memo { get; set; }
        public bool p_zg_oz { get; set; }
        public bool p_zg_std { get; set; }
        public int ID { get; set; }
        public Nullable<System.DateTime> AssignedOn { get; set; }
        public string AssignedTo { get; set; }
        public string PassPdbNr { get; set; }
        public string Customer_Number { get; set; }
    }
}