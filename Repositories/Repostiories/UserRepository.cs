using BussinessObject.Models;
using Models.DTOs;

namespace BussinessObject.Models;

public class UserRepository : BaseCRUD<TblUser>, IUserRepository
{
    private PersonalStoreContext _context;

    public long CountUsers()
    {
        _context = new PersonalStoreContext();
        return _context.Set<TblUser>().LongCount();
    }
    //Methods Create
    public TblUser CreateUser(TblUser user)
    {
        return Create(user);
    }

    public TblUser Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public List<TblUser> GetAllUsers()
    {
        return FindAll();
    }

    //Methods Read
    public TblUser GetUserById(string userId)
    {
        return FindById(userId);
    }
    
    public TblUser GetByUserName(string userName)
    {
        _context = new PersonalStoreContext();
        return _context.TblUsers.FirstOrDefault(u => u.UserName == userName);
    }
    
    public TblUser GetByEmail(string email)
    {
        _context = new PersonalStoreContext();
        return _context.TblUsers.FirstOrDefault(u => u.Email == email);
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