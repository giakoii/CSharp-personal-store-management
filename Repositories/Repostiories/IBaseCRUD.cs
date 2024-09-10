namespace BussinessObject.Models;

public interface IBaseCRUD<T> where T : class
{
    T Create(T entity);
    T GetById(string id);
    T Update(string id);
    T Delete(string id);
}

