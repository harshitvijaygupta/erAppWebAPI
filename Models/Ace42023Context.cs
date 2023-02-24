using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace erRelnAPI.Models;

public partial class Ace42023Context : DbContext
{
    public Ace42023Context()
    {
    }

    public Ace42023Context(DbContextOptions<Ace42023Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminArpit> AdminArpit { get; set; }

    public virtual DbSet<ArtUser> ArtUser { get; set; }

    public virtual DbSet<Artistishan> Artistishan { get; set; }

    public virtual DbSet<Authorhritik> Authorhritik { get; set; }

    public virtual DbSet<BookCollege> BookCollege { get; set; }

    public virtual DbSet<Bookhritik> Bookhritik { get; set; }

    public virtual DbSet<Bookuserhritik> Bookuserhritik { get; set; }

    public virtual DbSet<BrijeshBuyer> BrijeshBuyer { get; set; }

    public virtual DbSet<BrijeshProperty> BrijeshProperty { get; set; }

    public virtual DbSet<BrijeshSeller> BrijeshSeller { get; set; }

    public virtual DbSet<BrijeshTrans> BrijeshTrans { get; set; }

    public virtual DbSet<Companyawa> Companyawa { get; set; }

    public virtual DbSet<CourseArpit> CourseArpit { get; set; }

    public virtual DbSet<Customer> Customer { get; set; }

    public virtual DbSet<DakshUsers> DakshUsers { get; set; }

    public virtual DbSet<DeptFrp> DeptFrp { get; set; }

    public virtual DbSet<DeptRahul> DeptRahul { get; set; }

    public virtual DbSet<Emp> Emp { get; set; }

    public virtual DbSet<EmpArpit> EmpArpit { get; set; }

    public virtual DbSet<EmpAvaneshwari> EmpAvaneshwari { get; set; }

    public virtual DbSet<EmpBrijesh> EmpBrijesh { get; set; }

    public virtual DbSet<EmpDaksh> EmpDaksh { get; set; }

    public virtual DbSet<EmpHarsh> EmpHarsh { get; set; }

    public virtual DbSet<EmpHritik> EmpHritik { get; set; }

    public virtual DbSet<EmpIshwar> EmpIshwar { get; set; }

    public virtual DbSet<EmpJaivardhan> EmpJaivardhan { get; set; }

    public virtual DbSet<EmpManas> EmpManas { get; set; }

    public virtual DbSet<EmpPrem> EmpPrem { get; set; }

    public virtual DbSet<EmpSatyam> EmpSatyam { get; set; }

    public virtual DbSet<EmpUseravani> EmpUseravani { get; set; }

    public virtual DbSet<Empawanish> Empawanish { get; set; }

    public virtual DbSet<Empharshit> Empharshit { get; set; }

    public virtual DbSet<Empishan> Empishan { get; set; }

    public virtual DbSet<Empprabhat> Empprabhat { get; set; }

    public virtual DbSet<EmpsRahul> EmpsRahul { get; set; }

    public virtual DbSet<EmpsSameer> EmpsSameer { get; set; }

    public virtual DbSet<EmpsSuneet> EmpsSuneet { get; set; }

    public virtual DbSet<Empsuppawanish> Empsuppawanish { get; set; }

    public virtual DbSet<FlightAvani> FlightAvani { get; set; }

    public virtual DbSet<Flightawa> Flightawa { get; set; }

    public virtual DbSet<FlightbookingAvani> FlightbookingAvani { get; set; }

    public virtual DbSet<FlightuserAvani> FlightuserAvani { get; set; }

    public virtual DbSet<GradeCollege> GradeCollege { get; set; }

    public virtual DbSet<HarshitAuth> HarshitAuth { get; set; }

    public virtual DbSet<HarshitEmpAbout> HarshitEmpAbout { get; set; }

    public virtual DbSet<HarshitEmpList> HarshitEmpList { get; set; }

    public virtual DbSet<IBookings> IBookings { get; set; }

    public virtual DbSet<IFlights> IFlights { get; set; }

    public virtual DbSet<IUsers> IUsers { get; set; }

    public virtual DbSet<LoginAwa> LoginAwa { get; set; }

    public virtual DbSet<ManasFerry> ManasFerry { get; set; }

    public virtual DbSet<ManasPort> ManasPort { get; set; }

    public virtual DbSet<ManasTicket> ManasTicket { get; set; }

    public virtual DbSet<ManasUser> ManasUser { get; set; }

    public virtual DbSet<Painting> Painting { get; set; }

    public virtual DbSet<PatientsTable> PatientsTable { get; set; }

    public virtual DbSet<PlaceImages> PlaceImages { get; set; }

    public virtual DbSet<PremAttendance> PremAttendance { get; set; }

    public virtual DbSet<PremEmployee> PremEmployee { get; set; }

    public virtual DbSet<ProjectArpit> ProjectArpit { get; set; }

    public virtual DbSet<RahulBook> RahulBook { get; set; }

    public virtual DbSet<RahulBooking> RahulBooking { get; set; }

    public virtual DbSet<RahulUser> RahulUser { get; set; }

    public virtual DbSet<Reviews> Reviews { get; set; }

    public virtual DbSet<SameerLmsBookCollection> SameerLmsBookCollection { get; set; }

    public virtual DbSet<SameerLmsBookings> SameerLmsBookings { get; set; }

    public virtual DbSet<SameerLmsUser> SameerLmsUser { get; set; }

    public virtual DbSet<SameerLmslogin> SameerLmslogin { get; set; }

    public virtual DbSet<ServiceProviders> ServiceProviders { get; set; }

    public virtual DbSet<StudentArpit> StudentArpit { get; set; }

    public virtual DbSet<StudentCollege> StudentCollege { get; set; }

    public virtual DbSet<SuneetDept> SuneetDept { get; set; }

    public virtual DbSet<SuneetEmployee> SuneetEmployee { get; set; }

    public virtual DbSet<SuneetUsers> SuneetUsers { get; set; }

    public virtual DbSet<Team> Team { get; set; }

    public virtual DbSet<TouristPlaces> TouristPlaces { get; set; }

    public virtual DbSet<TransactionVrm> TransactionVrm { get; set; }

    public virtual DbSet<UserCollege> UserCollege { get; set; }

    public virtual DbSet<UserList> UserList { get; set; }

    public virtual DbSet<UserPrem> UserPrem { get; set; }

    public virtual DbSet<Userbtl> Userbtl { get; set; }

    public virtual DbSet<Userbtlishan> Userbtlishan { get; set; }

    public virtual DbSet<Userhritik> Userhritik { get; set; }

    public virtual DbSet<UsersRahul> UsersRahul { get; set; }

    public virtual DbSet<Usertbl> Usertbl { get; set; }

    public virtual DbSet<Usertbl2> Usertbl2 { get; set; }

    public virtual DbSet<Vehicle> Vehicle { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DEVSQL.corp.local;Database=ACE 4- 2023;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminArpit>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__Admin_Ar__CBA1B2574D9736C4");

            entity.Property(e => e.Userid).ValueGeneratedNever();
        });

        modelBuilder.Entity<ArtUser>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__art_user__DD70126488BB7E01");
        });

        modelBuilder.Entity<Artistishan>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("PK__artistis__DE508E2E425390CD");

            entity.Property(e => e.Aid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Authorhritik>(entity =>
        {
            entity.HasKey(e => e.Aid).HasName("PK__authorhr__C6970A10555A5A05");

            entity.Property(e => e.Aid).ValueGeneratedNever();
        });

        modelBuilder.Entity<BookCollege>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__bookColl__490D1AE108E2EE28");

            entity.Property(e => e.BookId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Bookhritik>(entity =>
        {
            entity.HasKey(e => e.Bookid).HasName("PK__bookhrit__8BEA95C5A0B3FD2E");

            entity.Property(e => e.Bookid).ValueGeneratedNever();

            entity.HasOne(d => d.Author).WithMany(p => p.Bookhritik).HasConstraintName("FK__bookhriti__autho__1F98B2C1");
        });

        modelBuilder.Entity<Bookuserhritik>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__bookuser__C5B69A4AC4341A6F");
        });

        modelBuilder.Entity<BrijeshBuyer>(entity =>
        {
            entity.HasKey(e => e.BuyerId).HasName("PK__Brijesh___BAD1715251431297");

            entity.Property(e => e.BuyerId).ValueGeneratedNever();
            entity.Property(e => e.InitBal).HasDefaultValueSql("((100))");
        });

        modelBuilder.Entity<BrijeshProperty>(entity =>
        {
            entity.HasKey(e => e.PropertyId).HasName("PK__Brijesh___735BA463E5D56375");

            entity.Property(e => e.PropertyId).ValueGeneratedNever();

            entity.HasOne(d => d.Sellerp).WithMany(p => p.BrijeshProperty).HasConstraintName("FK__Brijesh_p__selle__4C6B5938");
        });

        modelBuilder.Entity<BrijeshSeller>(entity =>
        {
            entity.HasKey(e => e.SellerId).HasName("PK__Brijesh___780A0A9702CCDD3D");

            entity.Property(e => e.SellerId).ValueGeneratedNever();
        });

        modelBuilder.Entity<BrijeshTrans>(entity =>
        {
            entity.HasKey(e => e.TransId).HasName("PK__brijesh___438CAC186C2792EF");

            entity.HasOne(d => d.Buyert).WithMany(p => p.BrijeshTrans).HasConstraintName("FK__brijesh_t__buyer__4E53A1AA");

            entity.HasOne(d => d.Prop).WithMany(p => p.BrijeshTrans).HasConstraintName("FK__brijesh_t__prop___4F47C5E3");
        });

        modelBuilder.Entity<Companyawa>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__companya__D837D05FC2E68D49");
        });

        modelBuilder.Entity<CourseArpit>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__Course_A__D837D05FD53A9C35");

            entity.Property(e => e.Cid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__Customer__CBA1B257F2C4ED15");
        });

        modelBuilder.Entity<DakshUsers>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__DakshUse__1788CC4C5F10387A");

            entity.Property(e => e.UserId).ValueGeneratedNever();
        });

        modelBuilder.Entity<DeptFrp>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK__dept_frp__C03122187BC50FC9");

            entity.Property(e => e.Did).ValueGeneratedNever();
        });

        modelBuilder.Entity<DeptRahul>(entity =>
        {
            entity.HasKey(e => e.Did).HasName("PK__dept_rah__D877D216FF2C365C");

            entity.Property(e => e.Did).ValueGeneratedNever();
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__Emp__C1971B53F11D094C");

            entity.Property(e => e.Eid).ValueGeneratedNever();

            entity.HasOne(d => d.TeamNameNavigation).WithMany(p => p.Emp).HasConstraintName("FK__Emp__Team_Name__336AA144");
        });

        modelBuilder.Entity<EmpArpit>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpArpit__D9509F6D748FA414");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpAvaneshwari>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empAvane__D9509F6DDA2524D9");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpBrijesh>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empBrije__D9509F6DFBBCEE86");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpDaksh>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpDaksh__C1971B53E4E8E96D");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpHarsh>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpHarsh__C1971B533A73B3F7");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpHritik>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empHriti__D9509F6D9EBABC74");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpIshwar>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empIshwa__D9509F6D71EE07E4");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpJaivardhan>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empJaiva__D9509F6D2BCB7371");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpManas>(entity =>
        {
            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpPrem>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empPrem__D9509F6D27559C2D");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpSatyam>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__EmpSatya__D9509F6D23134A4E");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpUseravani>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__empUsera__C5B69A4A38D0985D");

            entity.Property(e => e.Uid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Empawanish>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empawani__C1971B537D8161BB");

            entity.Property(e => e.Eid).ValueGeneratedNever();

            entity.HasOne(d => d.SIdNavigation).WithMany(p => p.Empawanish).HasConstraintName("FK__empawanish__S_id__68487DD7");
        });

        modelBuilder.Entity<Empharshit>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empharsh__D9509F6D853D881C");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Empishan>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empishan__D9509F6DC5134935");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Empprabhat>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empprabh__D9509F6DB7BF358E");

            entity.Property(e => e.Eid).ValueGeneratedNever();
        });

        modelBuilder.Entity<EmpsRahul>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empsRahu__D9509F6DEC4CB700");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.Edoj).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<EmpsSameer>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empsSame__D9509F6D10A6543F");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.Edoj).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<EmpsSuneet>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK__empsSune__D9509F6D3F2EB727");

            entity.Property(e => e.Eid).ValueGeneratedNever();
            entity.Property(e => e.Edoj).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Empsuppawanish>(entity =>
        {
            entity.HasKey(e => e.SId).HasName("PK__empsuppa__A3DCCCA5B9ECAFAA");

            entity.Property(e => e.SId).ValueGeneratedNever();
        });

        modelBuilder.Entity<FlightAvani>(entity =>
        {
            entity.HasKey(e => e.FlightNo).HasName("PK__flightAv__E3700CB103A7E6CB");

            entity.Property(e => e.FlightNo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Flightawa>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__flightaw__DD7012647DE9C8F3");

            entity.Property(e => e.Uid).ValueGeneratedNever();

            entity.HasOne(d => d.CidNavigation).WithMany(p => p.Flightawa).HasConstraintName("FK__flightawa__cid__5D60DB10");
        });

        modelBuilder.Entity<FlightbookingAvani>(entity =>
        {
            entity.HasKey(e => e.Bid).HasName("PK__flightbo__DE90ADE768208635");

            entity.Property(e => e.Bid).ValueGeneratedNever();

            entity.HasOne(d => d.FlightNoNavigation).WithMany(p => p.FlightbookingAvani).HasConstraintName("FK__flightboo__fligh__2C88998B");
        });

        modelBuilder.Entity<FlightuserAvani>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__flightus__CBA1B2574A92BF8A");

            entity.Property(e => e.Userid).ValueGeneratedNever();
        });

        modelBuilder.Entity<GradeCollege>(entity =>
        {
            entity.HasKey(e => new { e.Email, e.Subject }).HasName("PK__gradeCol__C78362F3494A794C");

            entity.HasOne(d => d.EmailNavigation).WithMany(p => p.GradeCollege)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_email");
        });

        modelBuilder.Entity<HarshitAuth>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__HarshitA__C9F28457BE78B4C4");
        });

        modelBuilder.Entity<HarshitEmpAbout>(entity =>
        {
            entity.HasKey(e => e.AId).HasName("PK__HarshitE__DE518A06C357C8FE");
        });

        modelBuilder.Entity<HarshitEmpList>(entity =>
        {
            entity.HasKey(e => e.EId).HasName("PK__HarshitE__D9519B452B638E65");
        });

        modelBuilder.Entity<IBookings>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__iBooking__5DE3A5B10159E289");

            entity.Property(e => e.BookingId).ValueGeneratedNever();

            entity.HasOne(d => d.Flight).WithMany(p => p.IBookings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__iBookings__fligh__41B8C09B");

            entity.HasOne(d => d.User).WithMany(p => p.IBookings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__iBookings__user___40C49C62");
        });

        modelBuilder.Entity<IFlights>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__iFlights__E3705765959FAB65");

            entity.Property(e => e.FlightId).ValueGeneratedNever();
        });

        modelBuilder.Entity<IUsers>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__iUsers__B9BE370F2D23F7C0");

            entity.Property(e => e.UserId).ValueGeneratedNever();
        });

        modelBuilder.Entity<LoginAwa>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__login_aw__CBA1B257090F5E79");
        });

        modelBuilder.Entity<ManasFerry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ManasFerry1");

            entity.HasOne(d => d.Destination).WithMany(p => p.ManasFerryDestination)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasFerry_ManasPort1");

            entity.HasOne(d => d.Origin).WithMany(p => p.ManasFerryOrigin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasFerry_ManasPort");
        });

        modelBuilder.Entity<ManasTicket>(entity =>
        {
            entity.HasOne(d => d.Ferry).WithMany(p => p.ManasTicket)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasTicket_ManasFerry");

            entity.HasOne(d => d.User).WithMany(p => p.ManasTicket)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManasTicket_ManasUser");
        });

        modelBuilder.Entity<Painting>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__Painting__DD37D91A3E6137C2");

            entity.Property(e => e.Pid).ValueGeneratedNever();

            entity.HasOne(d => d.Artist).WithMany(p => p.Painting).HasConstraintName("FK__Painting__artist__1CBC4616");
        });

        modelBuilder.Entity<PatientsTable>(entity =>
        {
            entity.HasKey(e => e.Pid).HasName("PK__patients__DD37D91A019C0A12");

            entity.Property(e => e.Pid).ValueGeneratedNever();
        });

        modelBuilder.Entity<PlaceImages>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PK__place_im__DC9AC955551DE3F3");

            entity.HasOne(d => d.Place).WithMany(p => p.PlaceImages).HasConstraintName("FK__place_ima__place__6F7F8B4B");
        });

        modelBuilder.Entity<PremAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PremAtte__3213E83F0164D6A1");

            entity.HasOne(d => d.Emp).WithMany(p => p.PremAttendanceEmp).HasConstraintName("FK__PremAtten__empId__1209AD79");

            entity.HasOne(d => d.Manager).WithMany(p => p.PremAttendanceManager).HasConstraintName("FK__PremAtten__manag__11158940");
        });

        modelBuilder.Entity<PremEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PremEmpl__3213E83FED4A9851");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager).HasConstraintName("FK__PremEmplo__manag__0E391C95");
        });

        modelBuilder.Entity<ProjectArpit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Project___3213E83F5182274A");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<RahulBook>(entity =>
        {
            entity.HasKey(e => e.BookId).HasName("PK__rahul_Bo__490D1AE1A7731EE7");
        });

        modelBuilder.Entity<RahulBooking>(entity =>
        {
            entity.HasKey(e => e.Bookingid).HasName("PK__rahul_Bo__C6D307052EFDAB3E");

            entity.HasOne(d => d.BidNavigation).WithMany(p => p.RahulBooking).HasConstraintName("FK__rahul_Booki__bid__1E6F845E");

            entity.HasOne(d => d.UidNavigation).WithMany(p => p.RahulBooking).HasConstraintName("FK__rahul_Booki__uid__1D7B6025");
        });

        modelBuilder.Entity<RahulUser>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__rahul_Us__CBA1B25753B271DE");
        });

        modelBuilder.Entity<Reviews>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__2ECD6E04FD5FD456");

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reviews__userid__640DD89F");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.Reviews)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reviews__vehicle__6501FCD8");
        });

        modelBuilder.Entity<SameerLmsBookCollection>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__SameerLM__447D36EBDB443295");
        });

        modelBuilder.Entity<SameerLmsBookings>(entity =>
        {
            entity.HasKey(e => e.Usbn).HasName("PK__SameerLM__AA65F839731F75C3");

            entity.HasOne(d => d.IsbnNavigation).WithMany(p => p.SameerLmsBookings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SameerLMS___ISBN__3DB3258D");

            entity.HasOne(d => d.User).WithMany(p => p.SameerLmsBookings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SameerLMS__UserI__3CBF0154");
        });

        modelBuilder.Entity<SameerLmsUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__SameerLM__1788CC4C7BB43450");
        });

        modelBuilder.Entity<SameerLmslogin>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__SameerLM__1788CC4CD4B51CD8");
        });

        modelBuilder.Entity<ServiceProviders>(entity =>
        {
            entity.HasKey(e => e.ProviderId).HasName("PK__service___00E2131085C74D5E");
        });

        modelBuilder.Entity<StudentArpit>(entity =>
        {
            entity.HasKey(e => e.Rollno).HasName("PK__Student___FABA8B5B9F5DA77E");

            entity.Property(e => e.Rollno).ValueGeneratedNever();

            entity.HasOne(d => d.CidNavigation).WithMany(p => p.StudentArpit).HasConstraintName("FK__Student_Arp__cid__23F3538A");
        });

        modelBuilder.Entity<StudentCollege>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__studentC__AB6E6165EC426050");
        });

        modelBuilder.Entity<SuneetDept>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK__Suneet_D__0148818EA754B5DB");

            entity.Property(e => e.DeptId).ValueGeneratedNever();
        });

        modelBuilder.Entity<SuneetEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Suneet_E__7AD04FF1F58F10EF");

            entity.Property(e => e.EmployeeId).ValueGeneratedNever();

            entity.HasOne(d => d.Dept).WithMany(p => p.SuneetEmployee).HasConstraintName("FK__Suneet_Em__DeptI__18B6AB08");
        });

        modelBuilder.Entity<SuneetUsers>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Suneet_U__1788CCACBFF2E4B3");

            entity.Property(e => e.UserId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Team>(entity =>
        {
            entity.HasKey(e => e.TeamName).HasName("PK__Team__16C2F8BF06095764");
        });

        modelBuilder.Entity<TouristPlaces>(entity =>
        {
            entity.HasKey(e => e.PlaceId).HasName("PK__tourist___BF2B684AD276B7B5");

            entity.HasMany(d => d.Provider).WithMany(p => p.Place)
                .UsingEntity<Dictionary<string, object>>(
                    "PlaceServiceProviders",
                    r => r.HasOne<ServiceProviders>().WithMany()
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__place_ser__provi__73501C2F"),
                    l => l.HasOne<TouristPlaces>().WithMany()
                        .HasForeignKey("PlaceId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__place_ser__place__725BF7F6"),
                    j =>
                    {
                        j.HasKey("PlaceId", "ProviderId").HasName("PK__place_se__AF25497BC7B13366");
                        j.ToTable("place_service_providers");
                        j.IndexerProperty<int>("PlaceId").HasColumnName("place_id");
                        j.IndexerProperty<int>("ProviderId").HasColumnName("provider_id");
                    });
        });

        modelBuilder.Entity<TransactionVrm>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Transact__9B57CF722FBCDF36");

            entity.HasOne(d => d.User).WithMany(p => p.TransactionVrm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transacti__useri__04AFB25B");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.TransactionVrm)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Transacti__vehic__03BB8E22");
        });

        modelBuilder.Entity<UserCollege>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("PK__userColl__AB6E6165A4C62A7A");
        });

        modelBuilder.Entity<UserList>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserList__1788CCACB1F20DE7");
        });

        modelBuilder.Entity<UserPrem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__userPrem__3213E83F69169E0F");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Userbtl>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__userbtl__1788CC4C1ACB02D1");

            entity.Property(e => e.UserId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Userbtlishan>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__userbtli__1788CC4C891106E7");

            entity.Property(e => e.UserId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Userhritik>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("PK__userhrit__1797D024DBE43055");

            entity.Property(e => e.Userid).ValueGeneratedNever();
        });

        modelBuilder.Entity<UsersRahul>(entity =>
        {
            entity.HasKey(e => e.Uid).HasName("PK__usersRah__DD7012643BA6E206");

            entity.Property(e => e.Uid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Usertbl>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Usertbl__1788CC4C7D51C4F2");
        });

        modelBuilder.Entity<Usertbl2>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Usertbl2__1788CC4CD87FA2C4");

            entity.Property(e => e.UserId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.VehicleId).HasName("PK__Vehicle__5B9D25F2FF662495");

            entity.Property(e => e.IsAvailable).HasDefaultValueSql("((1))");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
