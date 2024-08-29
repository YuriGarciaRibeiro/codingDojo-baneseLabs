using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.participantes.Dtos;
using WebApi.shared.appDbContext;
using WebApi.shared.controller;

namespace WebApi.participantes;

[Route("api/[controller]")]
[ApiController]
public class ParticipanteController: GenericRestController<Participante,ParticipanteRequest>
{
    public ParticipanteController(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}