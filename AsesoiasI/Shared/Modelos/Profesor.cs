using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoiasI.Shared.Modelos
{
    public class Profesor
    {
        [StringLength(100)]
        public int Id { get; set; }
       
        [StringLength(100)]
        [Required(ErrorMessage = "Debe escribir el nombre")]
        public string? Nombre { get; set;  }
        [StringLength(100)]
        [Required(ErrorMessage = "Debe escribir el Telefono")]
        public string? Telefono { get; set; }
        public virtual ICollection<Materia>? Materias { get; set; }

        public virtual ICollection<Alumno>? Alumnos { get; set; }




    }
}
