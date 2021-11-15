using Core.Abstract;

namespace Data.Abstract;

public interface IBaseData<T> where T : IKeyable
{
    public List<T> GetAll();
    public bool Add(T entity);
    public bool Remove(int id);
    public T Get(int id);
    public T Update(T entity);
}