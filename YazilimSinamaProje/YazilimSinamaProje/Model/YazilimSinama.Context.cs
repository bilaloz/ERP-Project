﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YazilimSinamaProje.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class yazilim_sinama_projesiEntities : DbContext
    {
        public yazilim_sinama_projesiEntities()
            : base("name=yazilim_sinama_projesiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<atik> atiks { get; set; }
        public virtual DbSet<bolum> bolums { get; set; }
        public virtual DbSet<kullanici> kullanicis { get; set; }
        public virtual DbSet<rapor> rapors { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<urunSatinAlma> urunSatinAlmas { get; set; }
        public virtual DbSet<zimmet> zimmets { get; set; }
    }
}
