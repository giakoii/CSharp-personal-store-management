namespace BussinessObject.Models;

public class BaseRepository<T> : IBaseCRUD<T> where T : class
{
    private PersonalStoreContext _context;

    private long count;
    
    public long Count()
    {
        _context = new PersonalStoreContext();
        count = _context.Set<T>().LongCount();
        return count;
    }
    public T Create(T entity)
    {
        _context = new PersonalStoreContext();
        _context.Add(entity);
        _context.SaveChanges();
        return entity;
    }
    
    public List<T> FindAll()
    {
        _context = new PersonalStoreContext();
        return _context.Set<T>().ToList();
    }

    public T FindById(string id)
    {
        _context = new PersonalStoreContext();
        return _context.Find<T>(id);
        
    }

    public T Update(string id)
    {
        _context = new PersonalStoreContext();
        var entity = _context.Find<T>(id);
        if (entity != null)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        return entity;
    }

    public T Delete(string id)
    {
        _context = new PersonalStoreContext();
        var entity = _context.Find<T>(id);
        if (entity != null)
        {
            _context.Update(id);
            _context.SaveChanges();
        }

        return entity;
    }
}