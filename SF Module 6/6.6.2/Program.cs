using System.Text.RegularExpressions;
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        User user = new User();

        user.Age = 20;
        user.Login = "ggg";

        user.EMail = "Ryabchikk@mail.ru";

        ReadKey();
    }
}

class User
{
    private int age;
    private string email;
    private string login;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть не меньше 18");
            }
            else
            {
                age = value;
            }
        }
    }

    public string Login
    {
        get
        {
            return login;
        }

        set
        {
            if (value.Length >= 3)
            {
                login = value;
            }
            else 
            { 
                Console.WriteLine("Логин должен быть длиной от 3 символов"); 
            }
        }
    }
    public string EMail
    {
        get
        {
            return email;
        }

        set
        {

            var mailCheker = new Regex(@"\w+@");
            bool checker = mailCheker.IsMatch(value);
            if (checker)
            {
                email = value;
                WriteLine($"Записан адреса электронной почты {value}");
            }
            else
            {
                Console.WriteLine("Неверный формат адреса электронной почты");
            }
        }
    }
}