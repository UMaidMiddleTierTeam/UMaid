﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UMAIDEntities : DbContext
    {
        public UMAIDEntities()
            : base("name=UMAIDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<CleaningLevel> CleaningLevels { get; set; }
        public virtual DbSet<Listing> Listings { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyInfo> PropertyInfoes { get; set; }
    }
}
