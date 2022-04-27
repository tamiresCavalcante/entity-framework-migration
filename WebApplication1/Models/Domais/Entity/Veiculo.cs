using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Domais.Entity
{
    [Table("tbl_veiculo")]
    public class Veiculo
    {
        [Column("veiculo_id", TypeName = "varchar(50)")]
        public string VeiculoId { get; set; }
        [Column("model", TypeName = "varchar(100)")]
        public string Modelo { get; set; }
        [Column("placa", TypeName = "varchar(20)")]
        public string Placa { get; set; }
        [Column("ano", TypeName = "int")]
        public int Ano { get; set; }
        public IList<MotoristaVeiculo> Motoristas { get; set; }

        public Veiculo()
        {
            VeiculoId = string.IsNullOrEmpty(VeiculoId) ? BaseEntity.GenerateId() : string.Empty;
        }
    }
}
