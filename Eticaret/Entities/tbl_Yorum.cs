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
    
    public partial class tbl_Yorum
    {
        public int Yorum_Id { get; set; }
        public Nullable<int> Kullanici_ID { get; set; }
        public Nullable<int> Urun_ID { get; set; }
        public Nullable<int> Yildiz { get; set; }
        public string Icerik { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
    
        public virtual tbl_Kullanici tbl_Kullanici { get; set; }
        public virtual tbl_Urun tbl_Urun { get; set; }
    }
}
