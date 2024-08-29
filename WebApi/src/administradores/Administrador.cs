using System.ComponentModel.DataAnnotations;

namespace WebApi.administradores;

public class Administrador
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Nome { get; set; }
    
    [Required]
    public string Email { get; set; }
}