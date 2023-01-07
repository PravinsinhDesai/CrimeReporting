using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrimeReporter.Models;


namespace CrimeReporter.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }
    public IActionResult Register(string fname,string lname,string email,string password)
    {
        List<User> ulist = UserManager.GetAllUser();
        // List<User> ulist=new List<User>();
        User u1 = new User(fname,lname,email,password);
        ulist.Add(u1);

        UserManager.RegInFile(ulist);

        return Redirect("/Home/Login") ;
    }

    public IActionResult Validate(string email,string password)
    {
        List<User> list =UserManager.GetAllUser();

        
        
    }

    
}