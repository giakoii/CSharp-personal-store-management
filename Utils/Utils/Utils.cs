using System.Globalization;
using System.Runtime.InteropServices.JavaScript;
using BussinessObject.Models;

namespace Utils;

public class Utils<T> : IUtils<T> where T : class
{
    public string CreateId(T entity, IBaseCRUD<T> repository)
    {
        string date = DateTime.Now.ToString("ddMMyyyy", CultureInfo.InvariantCulture);
        long count = repository.Count();
        string formattedCount = (count + 1).ToString("D3");
        string prefix = entity.GetType().Name.Substring(0, 1).ToUpper();
        return prefix + date + formattedCount;
        
    }
    
}