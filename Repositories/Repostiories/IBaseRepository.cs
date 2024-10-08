namespace BussinessObject.Models;

public interface IBaseRepository<T> where T : class
{
    long Count();
    T Create(T entity);
    List<T> FindAll();
    T FindById(string id);
    T Update(string id);
    T Delete(string id);
}

