using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.shared.controller;
using WebApi.locais.Dtos;
using WebApi.shared.appDbContext;

namespace WebApi.locais;

[Route("api/[controller]")]
[ApiController]
public class LocalController : GenericRestController<Local,LocalRequest>
{
    public LocalController(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}