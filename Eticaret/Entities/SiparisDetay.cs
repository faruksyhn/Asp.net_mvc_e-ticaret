//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eticaret.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SiparisDetay
    {
        public int SiparisDetayId { get; set; }
        public Nullable<int> SiparisId { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<int> UrunId { get; set; }
        public Nullable<System.DateTime> UrunSiparisTarihi { get; set; }
    
        public virtual Siparis Siparis { get; set; }
        public virtual tbl_Urun tbl_Urun { get; set; }
    }
}
