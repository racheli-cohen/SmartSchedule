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
    
    public partial class FinalProjectRachelShifiEntities2 : DbContext
    {
        public FinalProjectRachelShifiEntities2()
            : base("name=FinalProjectRachelShifiEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AddressConstraint> AddressConstraints { get; set; }
        public virtual DbSet<Age> Ages { get; set; }
        public virtual DbSet<AgeConstraint> AgeConstraints { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Day> Days { get; set; }
        public virtual DbSet<DayConstraint> DayConstraints { get; set; }
        public virtual DbSet<Exchanging> Exchangings { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<GenderConstraint> GenderConstraints { get; set; }
        public virtual DbSet<Neighborhood> Neighborhoods { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<YearForTeacher> YearForTeachers { get; set; }
    }
}
