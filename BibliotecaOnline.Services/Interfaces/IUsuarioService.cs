using BibliotecaOnline.Domain;

namespace BibliotecaOnline.Services.Interfaces
{
    public interface IUsuarioService
    {
        public Task InsertAsync(Usuario usuario);
    }
}