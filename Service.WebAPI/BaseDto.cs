using Core.Abstract;

namespace Service.WebAPI;

public class BaseDto : IKeyable
{
    public int Id { get; set; }
}