using AutoMapper;

using Core.Abstract;

using Data.Services.Abstract;

using Microsoft.AspNetCore.Mvc;

namespace Service.WebAPI;

public class BaseController<TEntity, TDto> : ControllerBase where TEntity : IKeyable where TDto : IKeyable
{
    private readonly IBaseService<TEntity> service;
    private readonly IMapper mapper;

    public BaseController(IBaseService<TEntity> service, IMapper mapper)
    {
        this.service = service;
        this.mapper = mapper;
    }

    // GET: api/<BaseController>
    [HttpGet]
    public virtual ActionResult Get()
    {
        return Ok(service.GetAll());
    }

    // GET api/<BaseController>/5
    [HttpGet("{id}")]
    public virtual ActionResult Get(int id)
    {
        return Ok(service.Get(id));
    }

    // POST api/<BaseController>
    [HttpPost]
    public virtual ActionResult<TDto> Post([FromBody] TDto value)
    {
        var mapValue = mapper.Map<TEntity>(value);

        return Ok(service.Add(mapValue));
    }

    // PUT api/<BaseController>/5
    [HttpPut("{id}")]
    public virtual ActionResult<TDto> Put(int id, [FromBody] TDto value)
    {
        try
        {
            var mapValue = mapper.Map<TEntity>(value);

            if (mapValue == null)
                return BadRequest("Hata kodu 400!");

            return Ok(service.Update(mapValue));
        }
        catch (Exception ex)
        {
            return BadRequest("Hata " + ex.Message);
        }
    }

    // DELETE api/<BaseController>/5
    [HttpDelete("{id}")]
    public virtual ActionResult Delete(int id)
    {
        return Ok(service.Remove(id));
    }
}