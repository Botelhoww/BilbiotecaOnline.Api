using BibliotecaOnline.Domain;

namespace BibliotecaOnline.Domain.Interfaces
{
    public interface ILivroRepository
    {
        public IEnumerable<Livro> GetAll();
        public Task<Livro> GetByIdAsync(int id);
        Task InsertAsync(Livro usuario);
        Task UpdateAsync(Livro usuario);
        Task DeleteAsync(int id);
    }
}
