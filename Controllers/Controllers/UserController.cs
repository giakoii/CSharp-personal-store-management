using BussinessObject.Models;
using Microsoft.AspNetCore.Mvc;
using Models.DTOs;
using Services.Services;

namespace Controllers.Controllers;

[Route("api/users")]
public class UserController : Controller
{
    private readonly IUserService _userService;
    
    public UserController()
    {
        _userService = new UserService();
    }
    
    
    //======================= Methods POST =======================
    [HttpPost("create")]
    public IActionResult CreateUser([FromBody]UserDTO userDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var user = _userService.CreateUser(userDto);
            return CreatedAtAction(nameof(GetByUserId), new { id = user.UserId }, user);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    //======================= Methods GET =======================
    [HttpGet("getAll")]
    public IActionResult GetAllUsers()
    {
        return Ok(_userService.GetAllUsers());
    }

    [HttpGet("{userId}")]
    public IActionResult GetByUserId(string userId)
    {
        var user = _userService.GetUserById(userId);
        if (user == null)
        {
            return NotFound($"User Id {userId} not found");
        }

        return Ok(user);
    }
    //======================= Methods PUT =======================
    
}

