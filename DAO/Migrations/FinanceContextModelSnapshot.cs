// <auto-generated />
using System;
using DAO.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAO.Migrations
{
    [DbContext(typeof(FinanceContext))]
    partial class FinanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("BLL.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Data_compra")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FaturaAssociadaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome_appbanco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome_compra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor_compra")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FaturaAssociadaId");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("BLL.Fatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.Property<double>("TotalFatura")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Fatura");
                });

            modelBuilder.Entity("BLL.Compra", b =>
                {
                    b.HasOne("BLL.Fatura", "FaturaAssociada")
                        .WithMany()
                        .HasForeignKey("FaturaAssociadaId");

                    b.Navigation("FaturaAssociada");
                });
#pragma warning restore 612, 618
        }
    }
}
