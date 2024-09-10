using BussinessObject.Models;

namespace Services.Services;

public class UserService
{
    private readonly IUserRepository _userRepository = new UserRepository();
    
    public TblUser CreateUser(TblUser user)
    {
        try
        {
            

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return user;
    }
    
    
}