using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.feedback;

public class Feedback
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10.")]
    public int Nota { get; set; }
    
    [Required]
    public string Descricao { get; set; }
    
    [Required]
    public DateTime DataHora { get; set; }
}