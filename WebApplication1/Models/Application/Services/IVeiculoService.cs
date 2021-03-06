using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Domais.Entity;

namespace WebApplication1.Models.Application.Services
{
    public interface IVeiculoService
    {
        Task Cadastrar(Veiculo veiculo);
        Task Atualizar(Veiculo veiculo);
        Task<List<Veiculo>> Listar();
        Task<List<Veiculo>> ListarDeOutraManeira();
        Task Excluir(string veiculoId);
        Task<Veiculo> Pesquisar(string veiculoId);

    }
}
