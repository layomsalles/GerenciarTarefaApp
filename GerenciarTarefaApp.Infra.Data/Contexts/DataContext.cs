using GerenciarTarefaApp.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace GerenciarTarefaApp.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaMap());
        }
    }
}
