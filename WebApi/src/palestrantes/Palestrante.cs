using System.ComponentModel.DataAnnotations;

namespace WebApi.palestrantes;

public class Palestrante
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Nome { get; set; }
    
    [Required]
    public string Assunto { get; set; }
    
    [Required]
    public string Cpf { get; set; }
}