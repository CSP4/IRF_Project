﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoversenySzimulator
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LoversenyAdatbazisEntities : DbContext
    {
        public LoversenyAdatbazisEntities()
            : base("name=LoversenyAdatbazisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hors> Horses { get; set; }
        public virtual DbSet<Jockey> Jockeys { get; set; }
        public virtual DbSet<Race> Races { get; set; }
    }
}
