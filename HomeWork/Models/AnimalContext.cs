using Microsoft.EntityFrameworkCore;

namespace HomeWork.Models;

public class AnimalContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }
    public AnimalContext(DbContextOptions<AnimalContext> options) : base(options){}
}