namespace WebApi.participantes.Dtos;

public class ParticipanteRequest
{
    public string Nome { get; set; }

    public string Cpf { get; set; }
    
    public DateTime DataNascimento { get; set; }
}