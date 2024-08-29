using System.ComponentModel.DataAnnotations;

namespace WebApi.participantes;

public class Participante
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Nome { get; set; }
    
    [Required]
    public string Cpf { get; set; }
    
    [Required]
    public DateTime DataNascimento { get; set; }
}