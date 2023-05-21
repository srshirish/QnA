using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QnA.Models;
using BLL;

namespace QnA.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult SignIn()
    {
        return View();
    }

    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SignUp(string firstname, string lastname, string email, string password)
    {   
        string tempName=firstname+" "+lastname;
        string tempEmail=email;
        string tempToken=SecurityTokenGenerator.GenerateSecurityToken(firstname,email);
        string tempPassword=DataEncryptor.Encrypt(password);
        User tempUser=new User(Name)
        return null;
    }

    public IActionResult RecoverPassword()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
