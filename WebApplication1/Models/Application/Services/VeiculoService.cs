using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Domais.Entity;
using WebApplication1.Models.Insfrastructure.Repository;

namespace WebApplication1.Models.Application.Services
{
    public class VeiculoService : IVeiculoService
    {
        private readonly IVeiculoRepositorio _veiculoRepositorio;

        public VeiculoService(IVeiculoRepositorio veiculoRepositorio)
        {
            _veiculoRepositorio = veiculoRepositorio;
        }
        public async Task Atualizar(Veiculo veiculo)
        {
            try
            {
                await _veiculoRepositorio.Atualizar(veiculo);
            } 
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task Cadastrar(Veiculo veiculo)
        {
            try
            {
                await _veiculoRepositorio.Cadastrar(veiculo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task Excluir(string veiculoId)
        {
            try
            {
                await _veiculoRepositorio.Excluir(veiculoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Veiculo>> Listar()
        {
            try
            {
                return await _veiculoRepositorio.Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Veiculo>> ListarDeOutraManeira()
        {
            try
            {
                return await _veiculoRepositorio.ListarDeOutraManeira();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Veiculo> Pesquisar(string veiculoId)
        {
            try
            {
                return await _veiculoRepositorio.Pesquisar(veiculoId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
