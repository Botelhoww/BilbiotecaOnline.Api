using BibliotecaOnline.Domain;

namespace BibliotecaOnline.Services.Interfaces
{
    public interface IUsuarioRepository
    {
        public Task<List<Usuario>> GetAllUsuariosAsync();
        public Task<Usuario> GetUsuarioAsync(int id);
        Task InsertAsync(Usuario usuario);
        Task UpdateAsync(Usuario usuario);
        Task DeleteAsync(int id);
    }
}
