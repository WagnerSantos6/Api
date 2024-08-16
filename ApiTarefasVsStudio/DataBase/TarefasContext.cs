

using ApiTarefasVsStudio.Models;

using Microsoft.EntityFrameworkCore;

namespace ApiTarefasVsStudio.DataBase
{
    public class TarefasContext : DbContext
    {
#nullable disable
        public TarefasContext(DbContextOptions<TarefasContext> options) : base(options)
        {
        }
        
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
