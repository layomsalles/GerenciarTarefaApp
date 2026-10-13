using GerenciarTarefaApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciarTarefaApp.Infra.Data.Mappings
{
    public class TarefaMap : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("Tarefas");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Titulo).IsRequired().HasMaxLength(100);

            builder.Property(t => t.Descricao);

            builder.Property(t => t.DataCriacao);

            builder.Property(t => t.DataConclusao);

            builder.Property(t => t.Status).HasConversion<string>();
        }
    }
}
