using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PharmacyApp_Week11_Final.Models.DBGenerated
{
    public partial class PatientContext : DbContext
    {
        public PatientContext()
        {
        }

        public PatientContext(DbContextOptions<PatientContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HealthInsurance> HealthInsurances { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PharmacyAccount> PharmacyAccounts { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionLineItem> PrescriptionLineItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=PatientDBContext");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<HealthInsurance>(entity =>
            {
                entity.Property(e => e.HealthInsuranceId).ValueGeneratedNever();

                entity.Property(e => e.HealthInsuranceDescription).IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.PatientAddress1).IsUnicode(false);

                entity.Property(e => e.PatientAddress2).IsUnicode(false);

                entity.Property(e => e.PatientCity).IsUnicode(false);

                entity.Property(e => e.PatientContactEmail).IsUnicode(false);

                entity.Property(e => e.PatientContactFirstName).IsUnicode(false);

                entity.Property(e => e.PatientContactLastName).IsUnicode(false);

                entity.Property(e => e.PatientName).IsUnicode(false);

                entity.Property(e => e.PatientPhone).IsUnicode(false);

                entity.Property(e => e.PatientState)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.PatientZipCode).IsUnicode(false);

                entity.HasOne(d => d.DefaultHealthInsurance)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DefaultHealthInsuranceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patients_fk_health_insurances");

                entity.HasOne(d => d.DefaultPharmacyNumberNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.DefaultPharmacyNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("patients_fk_pharmacy_accounts");
            });

            modelBuilder.Entity<PharmacyAccount>(entity =>
            {
                entity.HasKey(e => e.PharmacyNumber)
                    .HasName("PK__pharmacy__CD4189EB08FCE2E2");

                entity.Property(e => e.PharmacyNumber).ValueGeneratedNever();

                entity.Property(e => e.PharmacyDescription).IsUnicode(false);
            });

            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.Property(e => e.PrescriptionNumber).IsUnicode(false);

                entity.HasOne(d => d.HealthInsurance)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.HealthInsuranceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prescriptions_fk_health_insurances");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("prescriptions_fk_patients");
            });

            modelBuilder.Entity<PrescriptionLineItem>(entity =>
            {
                entity.HasKey(e => new { e.PrescriptionId, e.PrescritionSequence })
                    .HasName("line_items_pk");

                entity.Property(e => e.LineItemDescription).IsUnicode(false);

                entity.HasOne(d => d.PharmacyNumberNavigation)
                    .WithMany(p => p.PrescriptionLineItems)
                    .HasForeignKey(d => d.PharmacyNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("line_items_fk_accounts");

                entity.HasOne(d => d.Prescription)
                    .WithMany(p => p.PrescriptionLineItems)
                    .HasForeignKey(d => d.PrescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("line_items_fk_prescriptions");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
