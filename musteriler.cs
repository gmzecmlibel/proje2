//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace huray
{
    using System;
    using System.Collections.Generic;
    
    public partial class musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public musteriler()
        {
            this.categori = new HashSet<categori>();
        }
    
        public int mus_id { get; set; }
        public string mus_adsoy { get; set; }
        public string mus_tel { get; set; }
        public Nullable<int> urun_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<categori> categori { get; set; }
        public virtual urunler urunler { get; set; }
    }
}
