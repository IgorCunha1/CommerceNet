using Business.Interfaces;
using Data.ViewModel.Produto;
using Microsoft.AspNetCore.Mvc;

namespace CommerceNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        [Route("/{id}")]
        public async Task<IActionResult> ObterProdutoPorId([FromRoute] int id)
        {
            try
            {
                return Ok(await _produtoService.ObterProdutoPorId(id));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ObterProduto()
        {
            try
            {
                return Ok(await _produtoService.ObterProdutos());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> InserirProduto([FromBody] CadastroProdutoViewModel viewModel)
        {
            try
            {
                await _produtoService.InserirProduto(viewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditarProduto([FromBody] EditarProdutoViewModel viewModel)
        {
            try
            {
                await _produtoService.EditarProduto(viewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        
        [HttpDelete]
        [Route("/{id}")]
        public async Task<IActionResult> DeletarProduto([FromRoute] int id)
        {
            try
            {
                await _produtoService.DeletarProduto(id);
                return Ok();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
