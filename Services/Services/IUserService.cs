using System.Diagnostics;
using BussinessObject.Models;
using Models.DTOs;

namespace Services.Services;

public interface IUserService
{
    TblUser CreateUser(UserDTO userDTO);
    TblUser Login(string username, string password);
    List<TblUser> GetAllUsers();
    TblUser GetUserById(string userId);
    TblUser GetByUserName(string userName);
    TblUser GetByEmail(string email);
    TblUser UpdateUser(String userId);
    TblUser DeleteUser(string userId);
}