﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace library
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class librariesEntities : DbContext
    {
        public librariesEntities()
            : base("name=librariesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BorrowedBooks> BorrowedBooks { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<Librarians> Librarians { get; set; }
        public virtual DbSet<Publishing> Publishing { get; set; }
        public virtual DbSet<Readers> Readers { get; set; }
        public virtual DbSet<ReturnedBooks> ReturnedBooks { get; set; }
        public virtual DbSet<Shifts> Shifts { get; set; }
    }
}
