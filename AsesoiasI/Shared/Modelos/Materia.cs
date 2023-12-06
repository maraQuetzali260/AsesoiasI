using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoiasI.Shared.Modelos
{
    public class Materia
    {
        [StringLength(100)]
        public int Id { get; set; }
        [StringLength(100)]
        public string? Nombre { get; set; }
        [StringLength(100)]
        public string? Costo { get; set; }

        public virtual ICollection<Alumno>? Alumnos { get; set; }

        public int ProfesroId { get; set; }
        public Profesor? Profesor { get; set; } 



    }
}
