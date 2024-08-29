using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.agenda.Dtos;
using WebApi.shared.appDbContext;
using WebApi.shared.controller;

namespace WebApi.agenda;

[Route("api/[controller]")]
[ApiController]
public class AgendaController : GenericRestController<Agenda,AgendaRequest>
{
    public AgendaController(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }    
}