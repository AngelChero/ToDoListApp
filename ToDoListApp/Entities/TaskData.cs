using System.ComponentModel.DataAnnotations;

namespace ToDoListApp.Entities
{
    public class TaskData
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(150, 
                      MinimumLength = 6, 
                      ErrorMessage = "El campo {0} requiere como mínimo {2} y máximo {1} caracteres")]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [StringLength(150,
                      MinimumLength = 6,
                      ErrorMessage = "El campo {0} requiere como mínimo {2} y máximo {1} caracteres")]
        [Display(Name = "Descripción")]

        public string Description { get; set; }

        [Display(Name = "Orden")]
        public int Order { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Creación")]
        public DateTime CreationDate { get; set; }
    }
}
