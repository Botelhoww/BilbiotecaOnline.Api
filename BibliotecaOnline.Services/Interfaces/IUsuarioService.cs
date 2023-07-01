using BibliotecaOnline.Domain;

namespace BibliotecaOnline.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task InsertAsync(Usuario usuario);
        public Task DeleteAsync(int id);
        public Task UpdateAsync(Usuario usuario);
        public IEnumerable<Usuario> GetAll();
        public Task<Usuario> GetByIdAsync(int id);
    }
}