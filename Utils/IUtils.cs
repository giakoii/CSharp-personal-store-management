using BussinessObject.Models;

namespace Utils;

public interface IUtils<T> where T : class
{
    string CreateId(T entity, IBaseCRUD<T> repository);
}