using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsesoiasI.Shared.Modelos
{
    public class Alumno
    {
        
        [StringLength(100)]
        public int? Id { get; set; }
        [StringLength(100)]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "Debe escribir el Teléfono")]
        [StringLength(100)]
        public string? Telefono { get; set; }
        
        public int MateriaId { get; set; }
        public Materia? Materia { get; set; }

        public int ProfesorId { get; set; }
        public Profesor? Profesor { get; set; }

        
    }
}
