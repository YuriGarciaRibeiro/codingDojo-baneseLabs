using AutoMapper;
using WebApi.administradores;
using WebApi.administradores.Dtos;
using WebApi.agenda;
using WebApi.agenda.Dtos;
using WebApi.feedback;
using WebApi.feedback.Dtos;
using WebApi.locais;
using WebApi.locais.Dtos;
using WebApi.palestrantes;
using WebApi.palestrantes.Dtos;
using WebApi.participantes;
using WebApi.participantes.Dtos;

namespace WebApi.shared.mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Mapeamento de Administrador para AdministradorDTO e vice-versa
        CreateMap<Agenda, AgendaRequest>().ReverseMap();
        CreateMap<Administrador, AdministradorRequest>().ReverseMap();
        CreateMap<Feedback,FeedbackRequest>().ReverseMap();
        CreateMap<Local, LocalRequest>().ReverseMap();
        CreateMap<Palestrante, PalestranteRequest>().ReverseMap();
        CreateMap<Participante, ParticipanteRequest>().ReverseMap();

    }
}