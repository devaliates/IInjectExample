using Data.Abstract;
using Data.Entities;
using Data.Services.Abstract;

namespace Data.Services;

public class KisiService : BaseService<Kisi>, IKisiService
{
    public KisiService(IBaseData<Kisi> data) : base(data)
    {
    }
}