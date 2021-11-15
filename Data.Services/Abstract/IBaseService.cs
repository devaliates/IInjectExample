using Core.Abstract;

namespace Data.Services.Abstract;

public interface IBaseService<T> where T : IKeyable
{
    public List<T> GetAll();

    public T Get(int id);

    public T Update(T entity);

    public bool Add(T entity);

    public bool Remove(int id);
}