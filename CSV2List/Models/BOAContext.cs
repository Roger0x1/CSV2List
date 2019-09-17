using Microsoft.EntityFrameworkCore;

namespace CSV2List.Models
{
    public partial class BOAContext : DbContext
    {
        public BOAContext()
        {
        }

        public BOAContext(DbContextOptions<BOAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BoaParcels> BoaParcels { get; set; }
        public virtual DbSet<BoaTaxParcels> BoaTaxParcels { get; set; }

        public DbSet<BOA_Staging> Boa_Staging { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=YourDataSourceHere;Initial catalog=YourCatalogHere;UID=YourUIDHere; PWD=YourPWDHere;", x => x.UseNetTopologySuite());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<BoaParcels>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("R13_pk");

                entity.ToTable("BOA_PARCELS", "dbo");   

                entity.HasIndex(e => e.Pin)
                    .HasName("I4PIN");

                entity.HasIndex(e => e.Shape)
                    .HasName("S2_idx");

                entity.Property(e => e.Objectid)
                    .HasColumnName("OBJECTID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnName("created_date");

                entity.Property(e => e.CreatedUser)
                    .HasColumnName("created_user")
                    .HasMaxLength(255);

                entity.Property(e => e.LastEditedDate).HasColumnName("last_edited_date");

                entity.Property(e => e.LastEditedUser)
                    .HasColumnName("last_edited_user")
                    .HasMaxLength(255);

                entity.Property(e => e.Pin)
                    .HasColumnName("PIN")
                    .HasMaxLength(15);

                entity.Property(e => e.PinLegacy)
                    .HasColumnName("PIN_Legacy")
                    .HasMaxLength(20);

                entity.Property(e => e.Shape)
                    .HasColumnName("SHAPE")
                    .HasColumnType("geometry");
            });

            modelBuilder.Entity<BoaTaxParcels>(entity =>
            {
                entity.HasKey(e => e.Objectid)
                    .HasName("R15_pk");

                entity.ToTable("BOA_TAX_PARCELS", "dbo");

                entity.HasIndex(e => e.Shape)
                    .HasName("S4_idx");

                entity.Property(e => e.Objectid)
                    .HasColumnName("OBJECTID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Acres).HasColumnType("numeric(38, 8)");

                entity.Property(e => e.CommercialCat)
                    .HasColumnName("Commercial_Cat")
                    .HasMaxLength(50);

                entity.Property(e => e.DateUpdated).HasColumnName("Date_Updated");

                entity.Property(e => e.DistrictDryTrash)
                    .HasColumnName("District_DryTrash")
                    .HasMaxLength(10);

                entity.Property(e => e.DistrictEnterpriseZone)
                    .HasColumnName("District_EnterpriseZone")
                    .HasMaxLength(10);

                entity.Property(e => e.DistrictLighting)
                    .HasColumnName("District_Lighting")
                    .HasMaxLength(10);

                entity.Property(e => e.DistrictTad)
                    .HasColumnName("District_TAD")
                    .HasMaxLength(10);

                entity.Property(e => e.DistrictTransit)
                    .HasColumnName("District_Transit")
                    .HasMaxLength(10);

                entity.Property(e => e.EffectiveYb).HasColumnName("Effective_YB");

                entity.Property(e => e.FmvBuilding).HasColumnName("FMV_Building");

                entity.Property(e => e.FmvLand).HasColumnName("FMV_Land");

                entity.Property(e => e.LandFrontage1).HasColumnName("Land_Frontage_1");

                entity.Property(e => e.LandFrontage2).HasColumnName("Land_Frontage_2");

                entity.Property(e => e.LandFrontage3).HasColumnName("Land_Frontage_3");

                entity.Property(e => e.LandFrontage4).HasColumnName("Land_Frontage_4");

                entity.Property(e => e.LandType1)
                    .HasColumnName("Land_Type_1")
                    .HasMaxLength(10);

                entity.Property(e => e.LandType2)
                    .HasColumnName("Land_Type_2")
                    .HasMaxLength(10);

                entity.Property(e => e.LandType3)
                    .HasColumnName("Land_Type_3")
                    .HasMaxLength(10);

                entity.Property(e => e.LandType4)
                    .HasColumnName("Land_Type_4")
                    .HasMaxLength(10);

                entity.Property(e => e.LandUnits1)
                    .HasColumnName("Land_Units_1")
                    .HasColumnType("numeric(38, 8)");

                entity.Property(e => e.LandUnits2)
                    .HasColumnName("Land_Units_2")
                    .HasColumnType("numeric(38, 8)");

                entity.Property(e => e.LandUnits3)
                    .HasColumnName("Land_Units_3")
                    .HasColumnType("numeric(38, 8)");

                entity.Property(e => e.LandUnits4)
                    .HasColumnName("Land_Units_4")
                    .HasColumnType("numeric(38, 8)");

                entity.Property(e => e.LandUse1)
                    .HasColumnName("Land_Use_1")
                    .HasMaxLength(10);

                entity.Property(e => e.LandUse2)
                    .HasColumnName("Land_Use_2")
                    .HasMaxLength(10);

                entity.Property(e => e.LandUse3)
                    .HasColumnName("Land_Use_3")
                    .HasMaxLength(10);

                entity.Property(e => e.LandUse4)
                    .HasColumnName("Land_Use_4")
                    .HasMaxLength(10);

                entity.Property(e => e.LegalDescription)
                    .HasColumnName("Legal_Description")
                    .HasMaxLength(150);

                entity.Property(e => e.MailingAddress)
                    .HasColumnName("Mailing_Address")
                    .HasMaxLength(50);

                entity.Property(e => e.MailingCity)
                    .HasColumnName("Mailing_City")
                    .HasMaxLength(50);

                entity.Property(e => e.MailingState)
                    .HasColumnName("Mailing_State")
                    .HasMaxLength(20);

                entity.Property(e => e.MailingZip)
                    .HasColumnName("Mailing_Zip")
                    .HasMaxLength(12);

                entity.Property(e => e.Municipality).HasMaxLength(10);

                entity.Property(e => e.NbhdCodeBoa)
                    .HasColumnName("Nbhd_Code_BOA")
                    .HasMaxLength(20);

                entity.Property(e => e.Owner).HasMaxLength(50);

                entity.Property(e => e.Owner2).HasMaxLength(50);

                entity.Property(e => e.Pin)
                    .HasColumnName("PIN")
                    .HasMaxLength(15);

                entity.Property(e => e.PropAddressCity)
                    .HasColumnName("PropAddress_City")
                    .HasMaxLength(50);

                entity.Property(e => e.PropAddressFull)
                    .HasColumnName("PropAddress_Full")
                    .HasMaxLength(150);

                entity.Property(e => e.PropAddressNum)
                    .HasColumnName("PropAddress_Num")
                    .HasMaxLength(20);

                entity.Property(e => e.PropAddressPostDir)
                    .HasColumnName("PropAddress_PostDir")
                    .HasMaxLength(6);

                entity.Property(e => e.PropAddressPreDir)
                    .HasColumnName("PropAddress_PreDir")
                    .HasMaxLength(6);

                entity.Property(e => e.PropAddressState)
                    .HasColumnName("PropAddress_State")
                    .HasMaxLength(50);

                entity.Property(e => e.PropAddressStreetName)
                    .HasColumnName("PropAddress_StreetName")
                    .HasMaxLength(100);

                entity.Property(e => e.PropAddressStreetType)
                    .HasColumnName("PropAddress_StreetType")
                    .HasMaxLength(12);

                entity.Property(e => e.PropAddressUnitNum)
                    .HasColumnName("PropAddress_UnitNum")
                    .HasMaxLength(20);

                entity.Property(e => e.PropAddressUnitType)
                    .HasColumnName("PropAddress_UnitType")
                    .HasMaxLength(10);

                entity.Property(e => e.PropAddressZip)
                    .HasColumnName("PropAddress_Zip")
                    .HasMaxLength(12);

                entity.Property(e => e.PropertyUse)
                    .HasColumnName("Property_Use")
                    .HasMaxLength(6);

                entity.Property(e => e.SaleBook)
                    .HasColumnName("Sale_Book")
                    .HasMaxLength(20);

                entity.Property(e => e.SaleDd).HasColumnName("Sale_DD");

                entity.Property(e => e.SaleMm).HasColumnName("Sale_MM");

                entity.Property(e => e.SalePage)
                    .HasColumnName("Sale_Page")
                    .HasMaxLength(20);

                entity.Property(e => e.SalePrice).HasColumnName("Sale_Price");

                entity.Property(e => e.SaleQuality)
                    .HasColumnName("Sale_Quality")
                    .HasMaxLength(10);

                entity.Property(e => e.SaleYy).HasColumnName("Sale_YY");

                entity.Property(e => e.Shape)
                    .HasColumnName("SHAPE")
                    .HasColumnType("geometry");

                entity.Property(e => e.StephensDayByv).HasColumnName("StephensDay_BYV");

                entity.Property(e => e.StephensDayByvCpi).HasColumnName("StephensDay_BYV_CPI");

                entity.Property(e => e.TotalAssessment).HasColumnName("Total_Assessment");
            });
        }
    }
}
