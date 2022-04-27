using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Application.Services;
using WebApplication1.Models.Domais.Dto;
using WebApplication1.Models.Domais.Entity;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;

        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<List<Veiculo>> Listar()
        {
            try
            {
                return await _veiculoService.Listar();
            } 
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<string> Cadastrar([FromBody] VeiculoDTO veiculo)
        {
            try
            {
                var entidade = veiculo.ConverterParaEntidade();
                await _veiculoService.Cadastrar(entidade);
                return "cadastro efetuado";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("listardeoutramaneira")]
        public async Task<List<Veiculo>> ListarDeOutraManeira()
        {
            try
            {
                return await _veiculoService.ListarDeOutraManeira();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
