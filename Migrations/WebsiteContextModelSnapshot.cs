// <auto-generated />
using HW_Simple_Crud_Cli_App_NadavArania;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HW_Simple_Crud_Cli_App_NadavArania.Migrations
{
    [DbContext(typeof(WebsiteContext))]
    partial class WebsiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HW_Simple_Crud_Cli_App_NadavArania.Models.Field", b =>
                {
                    b.Property<int>("FieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FieldAge")
                        .HasColumnType("int");

                    b.Property<int>("FieldExperince")
                        .HasColumnType("int");

                    b.Property<string>("FieldName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FieldId");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("HW_Simple_Crud_Cli_App_NadavArania.Models.Journalist", b =>
                {
                    b.Property<int>("JournalistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("JournalistAge")
                        .HasColumnType("int");

                    b.Property<int>("JournalistExperince")
                        .HasColumnType("int");

                    b.Property<string>("JournalistName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JournalistId");

                    b.ToTable("Journalists");
                });
#pragma warning restore 612, 618
        }
    }
}
