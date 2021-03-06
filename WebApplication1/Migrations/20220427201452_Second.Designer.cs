// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models.Insfrastructure.Context;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ControleFrotaContext))]
    [Migration("20220427201452_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Domais.Entity.Motorista", b =>
                {
                    b.Property<string>("MotoristaId")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("motor_id");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CNH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("nome");

                    b.Property<DateTime>("ValidadeCNH")
                        .HasColumnType("datetime2");

                    b.HasKey("MotoristaId");

                    b.ToTable("tbl_motor");
                });

            modelBuilder.Entity("WebApplication1.Models.Domais.Entity.MotoristaVeiculo", b =>
                {
                    b.Property<string>("VeiculoId")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("veiculo_id");

                    b.Property<string>("MotoristaId")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("motor_id");

                    b.HasKey("VeiculoId", "MotoristaId");

                    b.HasIndex("MotoristaId");

                    b.ToTable("tbl_m_v");
                });

            modelBuilder.Entity("WebApplication1.Models.Domais.Entity.Veiculo", b =>
                {
                    b.Property<string>("VeiculoId")
                        .HasColumnType("varchar(50)")
                        .HasColumnName("veiculo_id");

                    b.Property<int>("Ano")
                        .HasColumnType("int")
                        .HasColumnName("ano");

                    b.Property<string>("Modelo")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("model");

                    b.Property<string>("Placa")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("placa");

                    b.HasKey("VeiculoId");

                    b.ToTable("tbl_veiculo");
                });

            modelBuilder.Entity("WebApplication1.Models.Domais.Entity.MotoristaVeiculo", b =>
                {
                    b.HasOne("WebApplication1.Models.Domais.Entity.Motorista", "Motorista")
                        .WithMany("Veiculos")
                        .HasForeignKey("MotoristaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Domais.Entity.Veiculo", "Veiculo")
                        .WithMany("Motoristas")
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Motorista");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("WebApplication1.Models.Domais.Entity.Motorista", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("WebApplication1.Models.Domais.Entity.Veiculo", b =>
                {
                    b.Navigation("Motoristas");
                });
#pragma warning restore 612, 618
        }
    }
}
