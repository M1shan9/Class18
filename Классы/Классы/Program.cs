using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
   Users user = new Users()
   {
    Name = "Mihail",
    Surname = "Aslamov",
    Login = "admin",
    Password = "admin",
   };
   Console.WriteLine(user.Name);
   Console.WriteLine("Write name");
   user.Name = Console.ReadLine();
   Console.WriteLine($"Write new name - {user.Name}");
   Console.ReadLine();
  }

  class Users
  {
   public string Name;
   public string Surname;

   public string Login;
   public string Password;
  }
 }
    }

