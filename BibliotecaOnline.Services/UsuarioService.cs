using BibliotecaOnline.Domain;
using BibliotecaOnline.Domain.Interfaces;
using BibliotecaOnline.Domain.Services;
using BibliotecaOnline.Services.Interfaces;

namespace BibliotecaOnline.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _usuarioRepository.GetByIdAsync(id);
        }

        public async Task InsertAsync(Usuario usuario)
        {
            if (EmailService.IsValid(usuario.Email))
                await _usuarioRepository.InsertAsync(usuario);
            else
                throw new Exception($"Email {usuario.Email} não é válido!");
        }

        public async Task UpdateAsync(Usuario usuario)
        {
            if (EmailService.IsValid(usuario.Email))
                await _usuarioRepository.UpdateAsync(usuario);
            else
                throw new Exception($"Email {usuario.Email} não é válido!");
        }

        public Task DeleteAsync(int id)
        {
            return _usuarioRepository.DeleteAsync(id);
        }
    }
}