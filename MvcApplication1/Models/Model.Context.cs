﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<addre> addres { get; set; }
        public DbSet<ad> ads { get; set; }
        public DbSet<catagory> catagories { get; set; }
        public DbSet<city> cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<message> messages { get; set; }
        public DbSet<state> states { get; set; }
        public DbSet<user> users { get; set; }
    }
}
