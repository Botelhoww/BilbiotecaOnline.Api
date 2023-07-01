using BibliotecaOnline.Domain;

namespace BibliotecaOnline.Domain.Interfaces
{
    public interface IUsuarioRepository
    {
        public IEnumerable<Usuario> GetAll();
        public Task<Usuario> GetByIdAsync(int id);
        Task InsertAsync(Usuario usuario);
        Task UpdateAsync(Usuario usuario);
        Task DeleteAsync(int id);
    }
}
