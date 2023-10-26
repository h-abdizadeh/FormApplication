using FardaTaxi.Database;
using FardaTaxi.Models;

namespace FardaTaxi;

public class Manage
{
    private static DatabaseContext context = new DatabaseContext();

    public bool AddUser(User user)
    {
        try
        {
            context.Users.Add(user);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            //throw;
            return false;
        }
    }

    public List<User> GetUsers()
    {
        var users = context.Users.ToList();
        return users;
    }

    public List<User> GetUsers(string search)
    {
        var users = 
            context.Users
            .Where(u => u.Id.ToString() == search || u.Lname.Contains(search))
            .ToList();

        return users;
    }

    public bool DeleteUser(int UserId)
    {
        var user = context.Users.Find(UserId);

        if(user==null) return false;

        context.Users.Remove(user);
        context.SaveChanges();
        return true;
    }
}
