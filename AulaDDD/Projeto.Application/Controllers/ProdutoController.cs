using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Models;
using Projeto.Domain.AggregatesModel.ProdutoAggregate;
using Projeto.Domain.Contracts.Services;

namespace Projeto.Application.Controllers
{
    [Authorize("Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] ProdutoCadastroModel model,
            [FromServices] IMapper mapper,
            [FromServices] IProdutoDomainService service)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var produto = mapper.Map<Produto>(model);
                    service.Cadastrar(produto);

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
        public IActionResult Put([FromBody] ProdutoEdicaoModel model,
            [FromServices] IMapper mapper,
            [FromServices] IProdutoDomainService service)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var produto = mapper.Map<Produto>(model);
                    service.Atualizar(produto);

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

        [HttpDelete("{idProduto}")]
        public IActionResult Delete(int idProduto,
            [FromServices] IProdutoDomainService service)
        {
            try
            {
                var produto = service.ObterPorId(idProduto);

                if (produto != null)
                {
                    service.Remover(produto);
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
        [ProducesResponseType(typeof(List<ProdutoConsultaModel>), StatusCodes.Status200OK)]
        public IActionResult GetAll([FromServices] IMapper mapper,
            [FromServices] IProdutoDomainService service)
        {
            try
            {
                var fornecedores = mapper.Map<List<ProdutoConsultaModel>>(service.ObterTodos());
                return Ok(fornecedores);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        [HttpGet("{idProduto}")]
        [ProducesResponseType(typeof(ProdutoConsultaModel), StatusCodes.Status200OK)]
        public IActionResult GetById(int idProduto,
            [FromServices] IMapper mapper,
            [FromServices] IProdutoDomainService service)
        {
            try
            {
                var produto = service.ObterPorId(idProduto);

                if (produto != null)
                {
                    var result = mapper.Map<ProdutoConsultaModel>(produto);
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