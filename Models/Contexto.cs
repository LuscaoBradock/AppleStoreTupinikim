
using Microsoft.EntityFrameworkCore;

namespace AppleStoreTupinikim.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbSet<Cliente>clientes) { }

        public Contexto(DbContextOptions<Contexto>opcoes) : base(opcoes) { }   
    }
}
