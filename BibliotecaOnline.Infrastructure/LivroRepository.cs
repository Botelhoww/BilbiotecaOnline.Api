using BibliotecaOnline.Domain;
using BibliotecaOnline.Domain.Interfaces;
using BibliotecaOnline.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaOnline.Infrastructure
{
    public class LivroRepository : ILivroRepository
    {
        private readonly BibliotecaContext _context;

        public LivroRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            var livro = await _context.Livros.FirstOrDefaultAsync(l => l.Id == id);

            if (livro != null)
            {
                _context.Remove(livro);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"Livro com ID {id} e Titulo {livro.Titulo} não encontrado.");
            }
        }

        public IEnumerable<Livro> GetAll()
        {
            return _context.Livros.ToList().OrderByDescending(l => l.Id);
        }

        public async Task<Livro> GetByIdAsync(int id)
        {
            return await _context.Livros.Where(l => l.Id == id).SingleAsync();
        }

        public async Task InsertAsync(Livro livro)
        {
            _context.Add(livro);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Livro livro)
        {
            _context.Update(livro);
            await _context.SaveChangesAsync();
        }
    }
}
