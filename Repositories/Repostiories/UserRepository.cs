using BussinessObject.Models;

namespace BussinessObject.Models;

public class UserRepository : BaseCRUD<TblUser>, IUserRepository
{
    //Methods Create
    public TblUser CreateUser(TblUser user)
    {
        return CreateUser(user);
    }
    
    //Methods Read
    public TblUser GetUserById(string userId)
    {
        return GetById(userId);
    }
    
    //Methods Update
    public TblUser UpdateUser(String userId)
    {
        return Update(userId);
    }
    //Methods Delete
    public TblUser DeleteUser(string userId)
    {
        return Delete(userId);
    }
}