

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.administradores.Dtos;
using WebApi.shared.appDbContext;
using WebApi.shared.controller;

namespace WebApi.administradores;

[Route("api/[controller]")]
[ApiController]
public class AdministradorController : GenericRestController<Administrador, AdministradorRequest>
{
    public AdministradorController(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
}