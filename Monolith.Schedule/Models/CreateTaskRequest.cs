using System.ComponentModel.DataAnnotations;

namespace Monolith.Schedule.Models
{
    public class CreateTaskRequest
    {
        [Required(ErrorMessage = "Raul eres el mejor de todos ....")]
        [MaxLength(5)]
        public string Contenido { get; set; }
    }
}
