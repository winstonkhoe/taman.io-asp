﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TamanEntities : DbContext
    {
        public TamanEntities()
            : base("name=TamanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<artist> artists { get; set; }
        public virtual DbSet<design_images> design_images { get; set; }
        public virtual DbSet<design> designs { get; set; }
        public virtual DbSet<garden_offers> garden_offers { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<seller> sellers { get; set; }
        public virtual DbSet<service_images> service_images { get; set; }
        public virtual DbSet<service> services { get; set; }
        public virtual DbSet<transaction_headers> transaction_headers { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<wallet> wallets { get; set; }
    }
}