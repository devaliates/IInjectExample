using Core.Abstract;

using Data.Abstract;
using Data.Services.Abstract;

namespace Data.Services;

public class BaseService<T> : IBaseService<T> where T : IKeyable
{
    protected readonly IBaseData<T> data;

    public BaseService(IBaseData<T> data)
    {
        this.data = data;
    }
    public virtual List<T> GetAll()
    {
        return this.data.GetAll();
    }

    public virtual T Get(int id)
    {
        return this.data.Get(id);
    }

    public virtual T Update(T entity)
    {
        return this.data.Update(entity);
    }

    public virtual bool Add(T entity)
    {
        return this.data.Add(entity);
    }

    public virtual bool Remove(int id)
    {
        return this.data.Remove(id);
    }
}