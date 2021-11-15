using Core.Abstract;

using Data.Abstract;

namespace Data.PostgreSQL;

public class BaseData<T> : IBaseData<T> where T : IKeyable
{
    protected readonly List<T> list;

    public BaseData()
    {
        list = new List<T>();
    }

    public bool Add(T entity)
    {
        entity.Id = list.Count + 1;

        this.list.Add(entity);
        return true;
    }

    public T Get(int id)
    {
        var item = list.FirstOrDefault(x => x.Id == id);

        if (item != null)
            return item;

        throw new ArgumentException("Kayıt bulunamadı!");
    }

    public List<T> GetAll()
    {
        return list;
    }

    public bool Remove(int id)
    {
        var item = list.FirstOrDefault(x => x.Id == id);

        if (item == null)
            return false;

        list.Remove(item);
        return true;
    }

    public T Update(T entity)
    {
        var item = list.FirstOrDefault(x => x.Id == entity.Id);

        if (item == null)
            throw new Exception("Kayıt bulunamadı!");

        list.Remove(item);
        list.Add(entity);

        return entity;
    }
}