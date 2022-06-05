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
    
    public partial class service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service()
        {
            this.service_images = new HashSet<service_images>();
            this.transaction_headers = new HashSet<transaction_headers>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int estimation_day { get; set; }
        public int price { get; set; }
        public int seller_id { get; set; }
        public byte[] created_at { get; set; }
    
        public virtual seller seller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service_images> service_images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transaction_headers> transaction_headers { get; set; }
    }
}