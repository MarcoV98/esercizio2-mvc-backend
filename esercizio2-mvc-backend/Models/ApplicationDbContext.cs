using esercizio2_mvc_backend.Models;
using System.Collections.Generic;

namespace esercizio2_mvc_backend.Models
public class ApplicationDbContext : DbContext
{
    public DbSet<Scarpa> Scarpe { get; set; }
}