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
    
    public partial class artist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public artist()
        {
            this.designs = new HashSet<design>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int reputation_point { get; set; }
        public int user_id { get; set; }
        public string image { get; set; }
        public byte[] created_at { get; set; }
    
        public virtual user user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<design> designs { get; set; }
    }
}
