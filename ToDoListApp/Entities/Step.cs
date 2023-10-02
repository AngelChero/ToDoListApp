using System.ComponentModel.DataAnnotations;

namespace ToDoListApp.Entities
{
    public class Step
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(250, 
                     MinimumLength = 6, 
                     ErrorMessage = "El campo {0} requiere como míni {2} y máximo {1} caracteres")]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "Realizado")]
        public bool Done { get; set; }

        [Display(Name = "Orden")]
        public int Order { get; set; }

        public int TaskDataId { get; set; }
        public TaskData TaskData { get; set; }
    }
}
