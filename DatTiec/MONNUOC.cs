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
    
    public partial class MONNUOC
    {
        public MONNUOC()
        {
            this.MENUs = new HashSet<MENU>();
        }
    
        public int MA_MN { get; set; }
        public string TENNUOC { get; set; }
        public Nullable<double> GIA { get; set; }
    
        public virtual ICollection<MENU> MENUs { get; set; }
    }
}