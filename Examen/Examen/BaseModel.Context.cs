﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ExamenEntities : DbContext
    {
        private static ExamenEntities _context;
        public ExamenEntities()
            : base("name=ExamenEntities")
        {
        }

        public static ExamenEntities GetContext()
        {
            if (_context == null)
                _context = new ExamenEntities();
            return _context;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Ед__изм> Ед__изм { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Поставщик> Поставщик { get; set; }
        public virtual DbSet<Пункт_получения_заказа> Пункт_получения_заказа { get; set; }
        public virtual DbSet<Роли> Роли { get; set; }
        public virtual DbSet<Состав_заказа> Состав_заказа { get; set; }
    }
}
