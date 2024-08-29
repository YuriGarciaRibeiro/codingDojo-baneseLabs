using System.ComponentModel.DataAnnotations;

namespace WebApi.agenda;

public class Agenda
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string NomeGestor { get; set; }
    
    [Required]
    public DateTime DataHora { get; set; }
    
    [Required]
    public string Repeticao { get; set; }
}