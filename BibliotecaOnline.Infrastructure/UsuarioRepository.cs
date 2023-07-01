using BibliotecaOnline.Domain;
using BibliotecaOnline.Infrastructure.Context;
using BibliotecaOnline.Services.Interfaces;

namespace BibliotecaOnline.Infrastructure
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BibliotecaContext _context;

        public UsuarioRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Usuario>> GetAllUsuariosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetUsuarioAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task InsertAsync(Usuario usuario)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
        }

        public Task UpdateAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}