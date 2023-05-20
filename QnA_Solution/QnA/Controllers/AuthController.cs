using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using QnA.Models;

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
        string tempToken=MyEncryptor.Encrypt(firstname+email);
        string tempPassword=MyEncryptor.Encrypt(firstname+email);
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
