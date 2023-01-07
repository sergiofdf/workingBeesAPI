using System.ComponentModel.DataAnnotations;

namespace WorkingBees.Core.Models.Dtos
{
    public class ExperienceDto
    {
        [Required(ErrorMessage = "Id de usuário obrigatório.")]
        public long UserId { get; set; }
        [Required(ErrorMessage = "Tipo obrigatório.")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Título obrigatório.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Data de início obrigatória.")]
        public DateTime InitialDate { get; set; }
        [Required(ErrorMessage = "Data de término obrigatória.")]
        public DateTime FinalDate { get; set; }
        [Required(ErrorMessage = "Descrição obrigatória.")]
        public string Description { get; set; }
    }
}
