using BibliotecaOnline.Domain;
using BibliotecaOnline.Domain.Interfaces;
using BibliotecaOnline.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaOnline.Infrastructure
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BibliotecaContext _context;

        public UsuarioRepository(BibliotecaContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Id == id);

            if (usuario != null)
            {
                _context.Remove(usuario);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception($"Usuário com ID {id} não encontrado.");
            }
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuarios.ToList().OrderByDescending(x => x.Id);
        }

        public async Task<Usuario> GetByIdAsync(int id)
        {
            return await _context.Usuarios.Where(x => x.Id == id).SingleAsync();
        }

        public async Task InsertAsync(Usuario usuario)
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Usuario usuario)
        {
            _context.Update(usuario);
            await _context.SaveChangesAsync();
        }
    }
}