using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ToDoListApp.Entities
{
    public class FileAttached
    {
        public Guid Id { get; set; }

        [Unicode]
        public string Url { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(150, 
                      MinimumLength = 6, 
                      ErrorMessage = "El campo {0} requiere como mínimo {2} y máximo {1} caracteres")]
        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Orden")]
        public int Order { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        public int TaskDataId { get; set; }
        public TaskData TaskData { get; set; }
    }
}
