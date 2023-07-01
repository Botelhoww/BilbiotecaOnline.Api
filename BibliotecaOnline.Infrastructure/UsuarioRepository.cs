using BibliotecaOnline.Domain;
using BibliotecaOnline.Services.Interfaces;

namespace BibliotecaOnline.Infrastructure
{
    public class UsuarioRepository : IUsuarioRepository
    {
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

        public Task InsertAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}