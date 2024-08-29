namespace WebApi.agenda.Dtos;

public class AgendaRequest
{
    public string NomeGestor { get; set; }
    
    public DateTime DataHora { get; set; }
    
    public string Repeticao { get; set; }
}