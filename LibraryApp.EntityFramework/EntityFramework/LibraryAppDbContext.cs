﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using LibraryApp.Authorization.Roles;
using LibraryApp.Authorization.Users;
using LibraryApp.Models;
using LibraryApp.MultiTenancy;

namespace LibraryApp.EntityFramework
{
    public class LibraryAppDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        public LibraryAppDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in LibraryAppDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of LibraryAppDbContext since ABP automatically handles it.
         */
        public LibraryAppDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public LibraryAppDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public LibraryAppDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
