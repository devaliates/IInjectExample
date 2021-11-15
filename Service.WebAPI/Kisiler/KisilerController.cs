using AutoMapper;

using Data.Entities;
using Data.Services.Abstract;

using Microsoft.AspNetCore.Mvc;

namespace Service.WebAPI.Kisiler;

[Route("api/v1/[controller]")]
[ApiController]
public class KisilerController : BaseController<Kisi, KisiDto>
{
    public KisilerController(IKisiService kisiService, IMapper mapper)
        : base(kisiService, mapper)
    {
    }
}