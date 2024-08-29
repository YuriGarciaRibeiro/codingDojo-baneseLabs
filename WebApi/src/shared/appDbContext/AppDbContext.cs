using Microsoft.EntityFrameworkCore;
using WebApi.administradores;
using WebApi.agenda;
using WebApi.feedback;
using WebApi.locais;
using WebApi.palestrantes;
using WebApi.participantes;

namespace WebApi.shared.appDbContext;

public class AppDbContext : DbContext
{
    public DbSet<Administrador> administradores { get; set; }
    public DbSet<Agenda> agendas { get; set; }
    public DbSet<Feedback> feedbacks { get; set; }
    public DbSet<Local> locais { get; set; }
    public DbSet<Palestrante> palestrantes { get; set; }
    public DbSet<Participante> participantes { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}
