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

        public Task Atualizar(Veiculo veiculo)
        {
            throw new NotImplementedException();
        }

        public Task Cadastrar(Veiculo veiculo)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(string veiculoId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Veiculo>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<List<Veiculo>> ListarDeOutraManeira()
        {
            throw new NotImplementedException();
        }

        public Task<Veiculo> Pesquisar(string veiculoId)
        {
            throw new NotImplementedException();
        }
    }
}
