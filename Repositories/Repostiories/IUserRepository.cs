namespace BussinessObject.Models;
public interface IUserRepository
{
    TblUser CreateUser(TblUser user);
    TblUser Login(string username, string password);
    List<TblUser> GetAllUsers();
    TblUser GetUserById(string userId);
    TblUser GetByUserName(string userName);
    TblUser GetByEmail(string email);
    TblUser UpdateUser(String userId);
    TblUser DeleteUser(string userId);
}