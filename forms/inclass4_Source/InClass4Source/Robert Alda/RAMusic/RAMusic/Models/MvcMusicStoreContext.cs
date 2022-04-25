using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RAMusic.Models
{
    public partial class MvcMusicStoreContext : DbContext
    {
        public MvcMusicStoreContext()
        {
        }

        public MvcMusicStoreContext(DbContextOptions<MvcMusicStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress19;Database=MvcMusicStore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Album>(entity =>
            {
                entity.ToTable("album");

                entity.Property(e => e.AlbumId).HasColumnName("albumId");

                entity.Property(e => e.AlbumArtUrl)
                    .HasMaxLength(50)
                    .HasColumnName("albumArtUrl");

                entity.Property(e => e.ArtistId).HasColumnName("artistId");

                entity.Property(e => e.GenreId).HasColumnName("genreId");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_album_artist");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.Albums)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_album_genre");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("artist");

                entity.Property(e => e.ArtistId).HasColumnName("artistId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("cart");

                entity.Property(e => e.CartId).HasColumnName("cartId");

                entity.Property(e => e.AlbumId).HasColumnName("albumId");

                entity.Property(e => e.CartCode)
                    .IsUnicode(false)
                    .HasColumnName("cartCode");

                entity.Property(e => e.Comments)
                    .IsUnicode(false)
                    .HasColumnName("comments");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("dateCreated");

                entity.Property(e => e.LineTotal).HasColumnName("lineTotal");

                entity.Property(e => e.UnitPrice).HasColumnName("unitPrice");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cart_album");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryCode);

                entity.ToTable("country");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("countryCode")
                    .IsFixedLength(true)
                    .HasComment("2-character short form for country");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasComment("formal name of country");

                entity.Property(e => e.PhonePattern)
                    .HasMaxLength(50)
                    .HasColumnName("phonePattern")
                    .HasComment("regular expression used to validate a phone number in this country, includes ^ and $");

                entity.Property(e => e.PostalPattern)
                    .HasMaxLength(120)
                    .HasColumnName("postalPattern")
                    .HasComment("regular expression used to validate the postal or zip code for this country, includes ^ and $");

                entity.Property(e => e.ProvinceStateLabel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("provinceStateLabel");

                entity.Property(e => e.RetailTaxRate).HasColumnName("retailTaxRate");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("genre");

                entity.Property(e => e.GenreId).HasColumnName("genreId");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("countryCode")
                    .IsFixedLength(true);

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("firstName");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("lastName");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasColumnName("orderDate");

                entity.Property(e => e.Phone)
                    .HasMaxLength(12)
                    .HasColumnName("phone");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(7)
                    .HasColumnName("postalCode");

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("provinceCode")
                    .IsFixedLength(true);

                entity.Property(e => e.Total).HasColumnName("total");

                entity.Property(e => e.UserName).HasColumnName("userName");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_order_country");

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProvinceCode)
                    .HasConstraintName("FK_order_province");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("orderDetail");

                entity.Property(e => e.OrderDetailId).HasColumnName("orderDetailId");

                entity.Property(e => e.AlbumId).HasColumnName("albumId");

                entity.Property(e => e.OrderId).HasColumnName("orderId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.UnitPrice).HasColumnName("unitPrice");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_orderDetail_album");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_orderDetail_order");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.ProvinceCode);

                entity.ToTable("province");

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("provinceCode")
                    .IsFixedLength(true)
                    .HasComment("2-character province code ... ON, BC, etc");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("countryCode")
                    .IsFixedLength(true);

                entity.Property(e => e.IncludesFederalTax).HasColumnName("includesFederalTax");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasComment("full province name ... Ontario, etc.");

                entity.Property(e => e.RetailTaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("retailTaxCode");

                entity.Property(e => e.RetailTaxRate).HasColumnName("retailTaxRate");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Provinces)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_province_country");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
