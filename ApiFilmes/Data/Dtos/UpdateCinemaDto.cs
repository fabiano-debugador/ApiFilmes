using System.ComponentModel.DataAnnotations;

namespace ApiFilmes.Data.Dtos
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "o campo nome é obrigatório.")]
        public string Nome { get; set; }
    }
}
