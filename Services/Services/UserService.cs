using BussinessObject.Models;
using Models.DTOs;
using Utils;

namespace Services.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    
    public UserService()
    {
        _userRepository = new UserRepository();
    }

    //======================================================
    public TblUser CreateUser(UserDTO userDTO)
    {
        if(_userRepository.GetByUserName(userDTO.UserName) != null)
            throw new Exception("User already exists");
        if (_userRepository.GetByEmail(userDTO.Email) != null)
            throw new Exception("Email already exists");

        TblUser user = new TblUser();
        var util = new Utils<TblUser>();
        var userId = util.CreateId(new TblUser(), (IBaseCRUD<TblUser>) _userRepository);
        try
        {
            user.UserId = userId;
            user.UserName = userDTO.UserName;
            user.Password = BCrypt.Net.BCrypt.HashPassword(userDTO.Password);
            user.Email = userDTO.Email;
            user.FullName = userDTO.FullName;
            user.NickName = userDTO.NickName;
            user.Phone = userDTO.Phone;
            user.Address = userDTO.Address;
            user.Status = Status.ENABLED;
            user.Role = Role.CUSTOMER;
            user.TblOrders = new List<TblOrder>();
            _userRepository.CreateUser(user);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        return user;
    }
    
    //======================================================
    public TblUser Login(string username, string password)
    {
        var user = _userRepository.GetByUserName(username);
        if (username == null || user.Status.Equals(Status.DISABLED))
        {
            throw new Exception("User not found");
        }

        if(!BCrypt.Net.BCrypt.Verify(user.Password, password))
        {
            throw new Exception("Password is incorrect");
        }

        return user;
    }

    //======================================================
    public List<TblUser> GetAllUsers()
    {
        return _userRepository.GetAllUsers();
    }

    //======================================================
    public TblUser GetUserById(string userId)
    {
        return _userRepository.GetUserById(userId);
    }

    //======================================================
    public TblUser GetByUserName(string userName)
    {
        return _userRepository.GetByUserName(userName);
    }

    //======================================================
    public TblUser GetByEmail(string email)
    {
        return _userRepository.GetByEmail(email);
    }

    public TblUser UpdateUser(string userId)
    {
        throw new NotImplementedException();
    }

    public TblUser DeleteUser(string userId)
    {
        throw new NotImplementedException();
    }
}