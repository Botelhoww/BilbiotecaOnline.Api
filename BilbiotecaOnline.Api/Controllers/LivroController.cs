using BibliotecaOnline.Domain;
using BibliotecaOnline.Services;
using BibliotecaOnline.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace BilbiotecaOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroService _livroService;

        public LivroController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet]
        public IEnumerable<Livro> GetAll()
        {
            return _livroService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Livro> GetByIdAsync(int id)
        {
            return await _livroService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync(Livro livro)
        {
            try
            {
                await _livroService.InsertAsync(livro);
                return CreatedAtAction("GetAll", livro);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Livro livro)
        {
            try
            {
                await _livroService.UpdateAsync(livro);
                return Ok();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _livroService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
