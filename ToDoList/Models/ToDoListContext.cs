using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}