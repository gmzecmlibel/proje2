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
    
    public partial class urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public urunler()
        {
            this.musteriler = new HashSet<musteriler>();
        }
    
        public int urun_id { get; set; }
        public string urun_ad { get; set; }
        public Nullable<int> urun_yıl { get; set; }
        public Nullable<int> cat_id { get; set; }
    
        public virtual categori categori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<musteriler> musteriler { get; set; }
    }
}
