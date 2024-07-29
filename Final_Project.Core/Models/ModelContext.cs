using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Final_Project.Core.Models
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aboutu> Aboutus { get; set; } = null!;
        public virtual DbSet<Airport> Airports { get; set; } = null!;
        public virtual DbSet<Background> Backgrounds { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<Contactu> Contactus { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<Footer> Footers { get; set; } = null!;
        public virtual DbSet<Header> Headers { get; set; } = null!;
        public virtual DbSet<Home> Homes { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Reservedflight> Reservedflights { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Testimonial> Testimonials { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=C##LocalUserDB;PASSWORD=admin;DATA SOURCE=localhost:1522/xe");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("C##LOCALUSERDB")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Aboutu>(entity =>
            {
                entity.HasKey(e => e.About_Us_Id)
                    .HasName("SYS_C008348");

                entity.ToTable("ABOUTUS");

                entity.Property(e => e.About_Us_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ABOUT_US_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Image_Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_NAME");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<Airport>(entity =>
            {
                entity.ToTable("AIRPORT");

                entity.Property(e => e.Airport_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("AIRPORT_ID");

                entity.Property(e => e.Airport_Name)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("AIRPORT_NAME");

                entity.Property(e => e.Location)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");
            });

            modelBuilder.Entity<Background>(entity =>
            {
                entity.ToTable("BACKGROUND");

                entity.Property(e => e.Background_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BACKGROUND_ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Image_Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_NAME");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasKey(e => e.Card_Id)
                    .HasName("SYS_C008323");

                entity.ToTable("BANK");

                entity.Property(e => e.Card_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CARD_ID");

                entity.Property(e => e.Balance)
                    .HasColumnType("FLOAT")
                    .HasColumnName("BALANCE");

                entity.Property(e => e.Cvv)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CVV");

                entity.Property(e => e.Expire_Date)
                    .HasColumnType("DATE")
                    .HasColumnName("EXPIRE_DATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<Contactu>(entity =>
            {
                entity.HasKey(e => e.Contact_Us_Id)
                    .HasName("SYS_C008344");

                entity.ToTable("CONTACTUS");

                entity.Property(e => e.Contact_Us_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CONTACT_US_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Message)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.ToTable("FLIGHT");

                entity.Property(e => e.Flight_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FLIGHT_ID");

                entity.Property(e => e.Additionalcost)
                    .HasColumnType("FLOAT")
                    .HasColumnName("ADDITIONALCOST");

                entity.Property(e => e.Arrival_Airport_Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ARRIVAL_AIRPORT_ID");

                entity.Property(e => e.Arrival_Datetime)
                    .HasColumnType("DATE")
                    .HasColumnName("ARRIVAL_DATETIME");

                entity.Property(e => e.Arrival_Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ARRIVAL_STATUS")
                    .HasDefaultValueSql("'false'\n");

                entity.Property(e => e.Departure_Airport_Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("DEPARTURE_AIRPORT_ID");

                entity.Property(e => e.Departure_Datetime)
                    .HasColumnType("DATE")
                    .HasColumnName("DEPARTURE_DATETIME");

                entity.Property(e => e.Flight_Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FLIGHT_NAME");

                entity.Property(e => e.Image_Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_NAME");

                entity.Property(e => e.Numberofemptyseats)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMBEROFEMPTYSEATS");

                entity.Property(e => e.Numberofreservedseats)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMBEROFRESERVEDSEATS");

                entity.Property(e => e.Price)
                    .HasColumnType("FLOAT")
                    .HasColumnName("PRICE");

                entity.HasOne(d => d.ArrivalAirport)
                    .WithMany(p => p.FlightArrivalAirports)
                    .HasForeignKey(d => d.Arrival_Airport_Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008336");

                entity.HasOne(d => d.DepartureAirport)
                    .WithMany(p => p.FlightDepartureAirports)
                    .HasForeignKey(d => d.Departure_Airport_Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008335");
            });

            modelBuilder.Entity<Footer>(entity =>
            {
                entity.ToTable("FOOTER");

                entity.Property(e => e.Footer_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("FOOTER_ID");

                entity.Property(e => e.Brief)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("BRIEF");

                entity.Property(e => e.Copyright)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("COPYRIGHT");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Linkstitle)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LINKSTITLE");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.Logo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LOGO");

                entity.Property(e => e.Phone_Number)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NUMBER");
            });

            modelBuilder.Entity<Header>(entity =>
            {
                entity.ToTable("HEADER");

                entity.Property(e => e.Header_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HEADER_ID");

                entity.Property(e => e.Header_Logo)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_LOGO");

                entity.Property(e => e.Header_Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_TITLE");

                entity.Property(e => e.Website_Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WEBSITE_NAME");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("HOME");

                entity.Property(e => e.HomeId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HOME_ID");

                entity.Property(e => e.AboutUsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ABOUT_US_ID");

                entity.Property(e => e.AdminUserId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ADMIN_USER_ID");

                entity.Property(e => e.BackgroundId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("BACKGROUND_ID");

                entity.Property(e => e.ContactUsId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CONTACT_US_ID");

                entity.Property(e => e.FooterId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FOOTER_ID");

                entity.Property(e => e.HeaderId)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("HEADER_ID");

                entity.HasOne(d => d.AboutUs)
                    .WithMany(p => p.Homes)
                    .HasForeignKey(d => d.AboutUsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008355");

                entity.HasOne(d => d.AdminUser)
                    .WithMany(p => p.Homes)
                    .HasForeignKey(d => d.AdminUserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008353");

                entity.HasOne(d => d.Background)
                    .WithMany(p => p.Homes)
                    .HasForeignKey(d => d.BackgroundId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008358");

                entity.HasOne(d => d.ContactUs)
                    .WithMany(p => p.Homes)
                    .HasForeignKey(d => d.ContactUsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008356");

                entity.HasOne(d => d.Footer)
                    .WithMany(p => p.Homes)
                    .HasForeignKey(d => d.FooterId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008357");

                entity.HasOne(d => d.Header)
                    .WithMany(p => p.Homes)
                    .HasForeignKey(d => d.HeaderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008354");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("PAYMENT");

                entity.Property(e => e.Payment_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PAYMENT_ID");

                entity.Property(e => e.Card_Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CARD_ID");

                entity.Property(e => e.User_Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ID");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Card_Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008326");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.User_Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008327");
            });

            modelBuilder.Entity<Reservedflight>(entity =>
            {
                entity.HasKey(e => e.Reserved_Flights_Id)
                    .HasName("SYS_C008338");

                entity.ToTable("RESERVEDFLIGHTS");

                entity.Property(e => e.Reserved_Flights_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RESERVED_FLIGHTS_ID");

                entity.Property(e => e.Email_Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL_STATUS")
                    .HasDefaultValueSql("'false'\n");

                entity.Property(e => e.Flight_Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("FLIGHT_ID");

                entity.Property(e => e.Numberofseats)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("NUMBEROFSEATS");

                entity.Property(e => e.Paid_Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PAID_STATUS")
                    .HasDefaultValueSql("'false'\n");

                entity.Property(e => e.Reservation_Date)
                    .HasColumnType("DATE")
                    .HasColumnName("RESERVATION_DATE");

                entity.Property(e => e.User_Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ID");

                entity.HasOne(d => d.Flight)
                    .WithMany(p => p.Reservedflights)
                    .HasForeignKey(d => d.Flight_Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008340");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reservedflights)
                    .HasForeignKey(d => d.User_Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008339");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLE");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_NAME");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("TESTIMONIAL");

                entity.Property(e => e.Testimonial_Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TESTIMONIAL_ID");

                entity.Property(e => e.Feedback)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("FEEDBACK");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STATUS")
                    .HasDefaultValueSql("'false'\n");

                entity.Property(e => e.User_Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("USER_ID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Testimonials)
                    .HasForeignKey(d => d.User_Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008330");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("USERS");

                entity.HasIndex(e => e.User_Name, "SYS_C008320")
                    .IsUnique();

                entity.Property(e => e.User_Name)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("USER_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.First_Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FIRST_NAME");

                entity.Property(e => e.Image_Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_NAME");

                entity.Property(e => e.Last_Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LAST_NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Role_Id)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.User_Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("USER_NAME");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Role_Id)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("SYS_C008321");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
