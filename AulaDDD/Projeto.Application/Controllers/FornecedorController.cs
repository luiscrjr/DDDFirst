using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Models; // camada de modelo de dados
using AutoMapper;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.AggregatesModel.FornecedorAggregate;

namespace Projeto.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] FornecedorCadastroModel model,
            [FromServices] IMapper mapper,
            [FromServices] IFornecedorDomainService service)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var fornecedor = mapper.Map<Fornecedor>(model);
                    service.Cadastrar(fornecedor);

                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] FornecedorEdicaoModel model,
            [FromServices] IMapper mapper,
            [FromServices] IFornecedorDomainService service)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var fornecedor = mapper.Map<Fornecedor>(model);
                    service.Atualizar(fornecedor);

                    return StatusCode(StatusCodes.Status204NoContent);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpDelete("{idFornecedor}")]
        public IActionResult Delete (int idFornecedor,
            [FromServices] IFornecedorDomainService service)
        {
            try
            {
                var fornecedor = service.ObterPorId(idFornecedor);

                if (fornecedor != null)
                {
                    service.Remover(fornecedor);
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status422UnprocessableEntity);
                }
                
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<FornecedorConsultaModel>), StatusCodes.Status200OK)]
        public IActionResult GetAll([FromServices] IMapper mapper,
            [FromServices] IFornecedorDomainService service)
        {
            try
            {
                var fornecedores = mapper.Map<List<FornecedorConsultaModel>>(service.ObterTodos());
                return Ok(fornecedores);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet ("{idFornecedor}")]
        [ProducesResponseType(typeof(FornecedorConsultaModel), StatusCodes.Status200OK)]
        public IActionResult GetById(int idFornecedor,
            [FromServices] IMapper mapper,
            [FromServices] IFornecedorDomainService service)
        {
            try
            {
                var fornecedor = service.ObterPorId(idFornecedor);

                if (fornecedor != null)
                {
                    var result = mapper.Map<FornecedorConsultaModel>(fornecedor);
                    return Ok(result);
                }
                else
                {
                    return NoContent();
                }
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

    }
}