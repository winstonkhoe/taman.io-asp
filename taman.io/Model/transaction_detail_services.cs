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
    
    public partial class transaction_detail_services
    {
        public int transaction_header_id { get; set; }
        public int service_id { get; set; }
        public int quantity { get; set; }
    
        public virtual service service { get; set; }
        public virtual transaction_headers transaction_headers { get; set; }
    }
}