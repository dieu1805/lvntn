//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatTiec
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        public NHANVIEN()
        {
            this.DONDATTIECs = new HashSet<DONDATTIEC>();
        }
    
        public int MA_NV { get; set; }
        public int ID { get; set; }
        public string TENNV { get; set; }
        public string CHUCVU { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
        public virtual ICollection<DONDATTIEC> DONDATTIECs { get; set; }
    }
}
