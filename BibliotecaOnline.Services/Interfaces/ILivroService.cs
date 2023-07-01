using BibliotecaOnline.Domain;

namespace BibliotecaOnline.Services.Interfaces
{
    public interface ILivroService
    {
        public Task InsertAsync(Livro livro);
        public Task DeleteAsync(int id);
        public Task UpdateAsync(Livro livro);
        public IEnumerable<Livro> GetAll();
        public Task<Livro> GetByIdAsync(int id);
    }
}
