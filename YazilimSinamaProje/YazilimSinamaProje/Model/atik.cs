//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YazilimSinamaProje.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class atik
    {
        public int atikID { get; set; }
        public string atikAdi { get; set; }
        public Nullable<int> urunID { get; set; }
        public Nullable<int> kullaniciID { get; set; }
    
        public virtual kullanici kullanici { get; set; }
        public virtual urunSatinAlma urunSatinAlma { get; set; }
    }
}
