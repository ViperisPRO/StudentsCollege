﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsCollege
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class vkonstantinovEntities : DbContext
    {
        public vkonstantinovEntities()
            : base("name=vkonstantinovEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }
        public virtual DbSet<ProductType> ProductType { get; set; }
    }
}
