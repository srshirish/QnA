namespace BLL;
using DAL;
using BOL;

public class AuthManager
{

    private readonly ContextCollection _context;

    public AuthManager()
    {
        _context = new ContextCollection();
    }

    public bool RegisterUser(User ud)
    {
        bool status = false;
        _context.Users.Add(ud);
        _context.SaveChanges();
        status = true;
        return status;
    }
    public bool ValidateUser(string fullName, string email)
    {
        // Check if a user with the given first name and email exists in the database

        // LINQ query to filter users based on first name and email
        var matchingUsers = from user in _context.Users
                            where user.FullName == fullName && user.Email == email
                            select user;

        // Check if any user matches the condition
        bool userExists = matchingUsers.Any();

        return userExists;
    }



}