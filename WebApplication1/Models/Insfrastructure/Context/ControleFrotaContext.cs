using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Domais.Entity;

namespace WebApplication1.Models.Insfrastructure.Context
{
    public class ControleFrotaContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<MotoristaVeiculo> MotoristasVeiculos { get; set; }
 
        public ControleFrotaContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configuração de chave composta
            modelBuilder.Entity<MotoristaVeiculo>()
                .ToTable("tbl_m_v")
                .HasKey(x => new { x.VeiculoId, x.MotoristaId });

            modelBuilder.Entity<MotoristaVeiculo>()
                .Property(x => x.VeiculoId)
                .HasColumnName("veiculo_id")
                .HasColumnType("varchar(50)");

            modelBuilder.Entity<MotoristaVeiculo>()
                .Property(x => x.MotoristaId)
                .HasColumnName("motor_id")
                .HasColumnType("varchar(50)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
