using Livaria.Domain.Abstractions;
using Livaria.Domain.Entities;
using Livaria.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livaria.Infrastructure.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly ApplicationDbContext _db;

        public LivroRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Livro> AdicionarLivro(Livro livro)
        {
            await _db.Livros.AddAsync(livro);
            await _db.SaveChangesAsync();
            return livro;
        }

        public async Task AtualizarLivro(Livro livro)
        {
            _db.Livros.Update(livro);
            await _db.SaveChangesAsync();
        }

        public async Task DeletarLivro(int id)
        {
            var livro = await _db.Livros.FindAsync(id);
            if (livro == null)
            {
                throw new InvalidOperationException("Livro não encontrado.");
            }
            _db.Livros.Remove(livro);
            await _db.SaveChangesAsync();
        }

        public async Task<Livro?> ObterLivro(int id)
        {
            return await _db.Livros.FindAsync(id);
        }

        public async Task<IEnumerable<Livro>> ObterLivros()
        {
            return await _db.Livros.ToListAsync();
        }
    }
}
