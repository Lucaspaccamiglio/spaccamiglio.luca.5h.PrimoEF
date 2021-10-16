using System;
using Microsoft.EntityFrameworkCore;

namespace spaccamiglio.luca._5h.PrimoEF
{

public class DbPersone : DbContext
{

public DbSet<Persona> Persone {get; set;} //relazione,tabella

protected override void OnConfiguring (DbContextOptionsBuilder options) {
{
    options.UseSqlite("Data Source=dbpersone.db");

}
    }
  }
}