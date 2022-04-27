﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Domais.Entity
{
    public class MotoristaVeiculo
    {
        public string MotoristaId { get; set; }
        public string VeiculoId { get; set; }
        public Motorista Motorista { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
