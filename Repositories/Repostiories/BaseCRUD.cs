namespace BussinessObject.Models;

public class BaseCRUD<T> : IBaseCRUD<T> where T : class
{
    private PersonalStoreContext _context;
    
    public T Create(T entity)
    {
        _context = new PersonalStoreContext();
        _context.Add(entity);
        _context.SaveChanges();
        return entity;
    }

    public T GetById(string id)
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
            _context.Remove(entity);
            _context.SaveChanges();
        }

        return entity;
    }
}