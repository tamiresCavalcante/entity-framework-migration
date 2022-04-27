using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Domais.Entity;
using WebApplication1.Models.Insfrastructure.Context;

namespace WebApplication1.Models.Insfrastructure.Repository
{
    public class VeiculoRepositorio : IVeiculoRepositorio
    {
        private readonly ControleFrotaContext _contextFrota;
        public VeiculoRepositorio(ControleFrotaContext context)
        {
            this._contextFrota = context;
        }

        public async Task Atualizar(Veiculo veiculo)
        {
            var atualizado = await Pesquisar(veiculo.VeiculoId);
            if(veiculo != null && !string.IsNullOrEmpty(veiculo.VeiculoId) && veiculo.VeiculoId.Equals(veiculo.VeiculoId))
            {
                atualizado.Modelo = veiculo.Modelo;
                atualizado.Ano = veiculo.Ano;
                atualizado.Placa = veiculo.Placa;

                _contextFrota.Veiculos.Update(atualizado);
            }
        }

        public async Task Cadastrar(Veiculo veiculo)
        {
            await _contextFrota.Veiculos.AddAsync(veiculo);
            await _contextFrota.SaveChangesAsync();
        }

        public async Task Excluir(string veiculoId)
        {
            var veiculo = await Pesquisar(veiculoId);
            if (veiculo != null && !string.IsNullOrEmpty(veiculo.VeiculoId) && veiculo.VeiculoId.Equals(veiculoId))
                _contextFrota.Veiculos.Remove(veiculo);
        }

        public async Task<List<Veiculo>> Listar()
        {
            return await _contextFrota.Veiculos.ToListAsync();
        }

        public async Task<List<Veiculo>> ListarDeOutraManeira()
        {
            var result = await _contextFrota.Veiculos
                .Include(c => c.Motoristas)
                .ThenInclude(y => y.Veiculo)
                .ToListAsync();

            foreach(var item in result)
            {
                foreach(var subitem in item.Motoristas)
                {
                    subitem.Motorista = _contextFrota.Motoristas.FirstOrDefault(m => m.MotoristaId.Equals(subitem.MotoristaId));
                }
            }

            return result;
        }

        public async Task<Veiculo> Pesquisar(string veiculoId)
        {
            return await _contextFrota.Veiculos.FirstOrDefaultAsync(v => v.VeiculoId.Equals(veiculoId));
        }
    }
}
