namespace Utils;

public interface IUtils<T> where T : class
{
    String CreateId(T id, T prefix);
}