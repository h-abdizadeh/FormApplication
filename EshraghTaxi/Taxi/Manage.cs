using Taxi.Database;
using Taxi.Models;

namespace Taxi;

public class Manage
{
    private static readonly DatabaseContext context = new DatabaseContext();

    public List<User> ShowUsers()
    {
        var users = context.Users.ToList();

        return users;
    }

    public List<User> ShowUsers(string search)
    {
        var users = context.Users.Where(u => u.Code.Contains(search) ||
                                         u.Lname.Contains(search)).ToList();

        return users;
    }

    public bool DeleteUser(int userId)
    {
        try
        {
            //var user = context.Users.FirstOrDefault(u => u.Id == userId);
            var user = context.Users.Find(userId);//base primary key

            //if user null
            if (user == null) return false;

            //if user not null
            //context.Users.Remove(user);
            context.Remove(user);
            context.SaveChanges();

            return true;
        }
        catch (Exception)
        {
            //throw;
            return false;
        }
    }

    public async Task<User> GetUser(int userId)
    {
        var user = await context.Users.FindAsync(userId);

        return user;
    }


    public bool EdiUser(User user)
    {
        try
        {
            var _user = context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (_user is null) return false;//==

            _user.Fname = user.Fname;
            _user.Lname = user.Lname;
            _user.Mobile = user.Mobile;
            _user.Address = user.Address;

            //context.Users.Update(user);
            context.SaveChanges();
            return true;
        }
        catch (Exception)
        {

            //throw;
            return false;
        }
    }

}
