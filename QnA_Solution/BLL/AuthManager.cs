namespace BLL;
using DAL;
using BOL;

public class AuthManager
{

    private readonly ContextCollection _context;

    public AuthManager(ContextCollection context)
    {
        _context = context;
    }

    public bool RegisterUser(User ud)
    {
        bool status = false;
        _context.Users.Add(ud);
        _context.SaveChanges();
        status = true;
        return status;
    }

}