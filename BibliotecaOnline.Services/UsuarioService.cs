using BibliotecaOnline.Domain;
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

        public async Task InsertAsync(Usuario usuario)
        {
            if (EmailService.IsValid(usuario.Email))
                await _usuarioRepository.InsertAsync(usuario);
            else
                throw new Exception("Email do Usuário não é válido");
        }
    }
}