using System.ComponentModel.DataAnnotations;

namespace WorkingBees.Core.Models
{
    public class Experience
    {
        public long UserId { get; set; }
        [Key]
        public long ExperienceId { get; set; }
        [Required(ErrorMessage = "Tipo obrigatório.")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Título obrigatório.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Data de início obrigatória.")]
        public string InitialDate { get; set; }
        [Required(ErrorMessage = "Data de término obrigatória.")]
        public string FinalDate { get; set; }
        [Required(ErrorMessage = "Descrição obrigatória.")]
        public string Description { get; set; }
    }
}
