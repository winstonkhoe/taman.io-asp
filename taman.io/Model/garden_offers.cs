//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace taman.io.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class garden_offers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public garden_offers()
        {
            this.transaction_headers = new HashSet<transaction_headers>();
        }
    
        public int id { get; set; }
        public int design_id { get; set; }
        public int seller_id { get; set; }
        public int price { get; set; }
        public byte[] valid_to { get; set; }
    
        public virtual design design { get; set; }
        public virtual seller seller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaction_headers> transaction_headers { get; set; }
    }
}
