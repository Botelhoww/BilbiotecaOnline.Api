using BibliotecaOnline.Domain;
using BibliotecaOnline.Services.Interfaces;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BilbiotecaOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _usuarioService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync(Usuario usuario)
        {
            try
            {
                var response = _usuarioService.InsertAsync(usuario);

                return CreatedAtAction("Post", response);
            }
            catch (ValidationException e)
            {
                //usar algum logger
                throw new ValidationException(e.Errors);
            }
            catch (Exception e)
            {
                //usar algum logger

                //return StatusCode(StatusCodes.Status500, e.Message);
                throw new Exception(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Usuario usuario)
        {
            try
            {
                await _usuarioService.UpdateAsync(usuario);
                return Ok();
            }
            catch (DbUpdateException e)
            {
                throw new DbUpdateException(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _usuarioService.DeleteAsync(id);
                return NoContent();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
