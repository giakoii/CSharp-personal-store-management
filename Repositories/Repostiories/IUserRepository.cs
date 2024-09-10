namespace BussinessObject.Models;
public interface IUserRepository
{
    TblUser CreateUser(TblUser user);
    TblUser GetUserById(string userId);
    TblUser UpdateUser(String userId);
    TblUser DeleteUser(string userId);
}