using ODataDemo.DAL.Model;

namespace ODataDemo.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LearnerContext : DbContext
    {
        public LearnerContext()
            : base("name=LernerContext")
        {
        }

        public virtual DbSet<Learner> Learners { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Learner>()
                .Property(e => e.gender)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Learner>()
                .Property(e => e.surname)
                .IsUnicode(false);

            

            modelBuilder.Entity<Learner>()
                .Property(e => e.forename)
                .IsUnicode(false);

            modelBuilder.Entity<Learner>()
                .Property(e => e.legal_surname)
                .IsUnicode(false);

            modelBuilder.Entity<Learner>()
                .Property(e => e.chosen_forename)
                .IsUnicode(false);

           

            modelBuilder.Entity<Learner>()
                .Property(e => e.dm_chosen_forename)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Learner>()
                .Property(e => e.dm_legal_surname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Learner>()
                .Property(e => e.honours)
                .IsUnicode(false);

            modelBuilder.Entity<Learner>()
                .Property(e => e.salutation)
                .IsUnicode(false);

            modelBuilder.Entity<Learner>()
                .Property(e => e.addressee)
                .IsUnicode(false);

            modelBuilder.Entity<Learner>()
                .Property(e => e.rowversion)
                .IsFixedLength();

            modelBuilder.Entity<Learner>()
                .Property(e => e.uid)
                .IsUnicode(false);
        }
    }
}
