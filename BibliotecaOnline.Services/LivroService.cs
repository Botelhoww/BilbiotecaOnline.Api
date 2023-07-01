using BibliotecaOnline.Domain;
using BibliotecaOnline.Domain.Interfaces;
using BibliotecaOnline.Services.Interfaces;


namespace BibliotecaOnline.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public Task DeleteAsync(int id)
        {
            return _livroRepository.DeleteAsync(id);
        }

        public IEnumerable<Livro> GetAll()
        {
            return _livroRepository.GetAll();
        }

        public Task<Livro> GetByIdAsync(int id)
        {
            return _livroRepository.GetByIdAsync(id);
        }

        public Task InsertAsync(Livro livro)
        {
            return _livroRepository.InsertAsync(livro);
        }

        public Task UpdateAsync(Livro livro)
        {
            return _livroRepository.UpdateAsync(livro);
        }
    }
}
