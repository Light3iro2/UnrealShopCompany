﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnrealShopCompany
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UnreaShopDbEntities : DbContext
    {
        public UnreaShopDbEntities()
            : base("name=UnreaShopDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<OrderList> OrderList { get; set; }
        public virtual DbSet<OrderSet> OrderSet { get; set; }
        public virtual DbSet<Return> Return { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
