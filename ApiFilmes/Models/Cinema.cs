using System.ComponentModel.DataAnnotations;

namespace ApiFilmes.Models;

public class Cinema
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "o campo nome é obrigatório.")] 
    public string Nome { get; set; }
}
