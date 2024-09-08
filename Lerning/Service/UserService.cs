using Lerning.Models;

namespace Lerning.Service;

public class UserService
{
    static List<User> Users { get; }
    static int nextID = 5;

    static UserService()
    {
        Users = new List<User>
        {
            new User { Id = 1, Name = "GIGANIGA", Email = "Savapidor@email.com", Password = "123124" },
            new User { Id = 2, Name = "Slava", Email = "SlavaCou@email.com", Password = "123124" },
            new User { Id = 3, Name = "Danila", Email = "Degenerat@email.com", Password = "123124" },
            new User { Id = 4, Name = "Nikita", Email = "Legenda@email.com", Password = "123124" },
        };
    }
    public static List<User> GetAll() => Users;

    public static User? Get(int id) => Users.FirstOrDefault(p=> p.Id == id);

    public static void Add(User user)
    {
        user.Id++;
        Users.Add(user);
    }

    public static void Delete(int Id) {
        var user = Get(Id);
        if(user is null)
        {
            return;
        }
        Users.Remove(user);
    }

    public static void Update(User user)
    {
        var index = Users.FindIndex(p=>p.Id == user.Id);
        if (index == -1)
        {
            return;
        }
        Users[index]= user;
    }
}
