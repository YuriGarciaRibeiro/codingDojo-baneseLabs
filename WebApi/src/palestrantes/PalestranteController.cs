using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.palestrantes.Dtos;
using WebApi.shared.appDbContext;
using WebApi.shared.controller;

namespace WebApi.palestrantes;

[Route("api/[controller]")]
[ApiController]
public class PalestranteController: GenericRestController<Palestrante,PalestranteRequest>
{
    public PalestranteController(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
}