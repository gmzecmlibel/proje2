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
    
    public partial class categori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categori()
        {
            this.urunler = new HashSet<urunler>();
        }
    
        public int cat_id { get; set; }
        public string cat_name { get; set; }
        public Nullable<int> mus_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<urunler> urunler { get; set; }
        public virtual musteriler musteriler { get; set; }
    }
}
