using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.feedback.Dtos;
using WebApi.shared.appDbContext;
using WebApi.shared.controller;

namespace WebApi.feedback;


[Route("api/[controller]")]
[ApiController]
public class FeedBackController : GenericRestController<Feedback,FeedbackRequest>
{
    public FeedBackController(AppDbContext context, IMapper mapper) : base(context, mapper)
    {
    }
}