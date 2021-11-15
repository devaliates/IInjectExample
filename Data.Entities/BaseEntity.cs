using Core.Abstract;

namespace Data.Entities;

public class BaseEntity : IKeyable
{
    public int Id { get; set; }
}