namespace WebApi.feedback.Dtos;

public class FeedbackRequest
{  
    public int Nota { get; set; }
    
    public string Descricao { get; set; }
    
    public DateTime DataHora { get; set; }
}