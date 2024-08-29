using System.ComponentModel.DataAnnotations;

namespace WebApi.locais;

public class Local
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Nome { get; set; }
    
    [Required]
    public string Cidade { get; set; }
    
    [Required]
    public string Estado { get; set; }
}