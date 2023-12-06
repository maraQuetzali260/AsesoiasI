using Microsoft.EntityFrameworkCore;
using AsesoiasI.Shared.Modelos;

namespace AsesoiasI.Server.Data

{
   public class BDContextAsesoria : DbContext
{
    public BDContextAsesoria(DbContextOptions<BDContextAsesoria> options) : base(options)
    {
    }
    public DbSet<Alumno> Alumnos { get; set; }
    public DbSet<Profesor> Profesores { get; set; }
    public DbSet<Materia> Materias { get; set; }
    
        


    }
}
