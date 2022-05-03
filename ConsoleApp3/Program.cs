class Programm
{

    static void Main(string[] args)
    {
        (string Name, string LastName, string Login, int LoginLength, bool Pet, string[] colors, int Age) User;
        Console.WriteLine("Введите своё имя: ");
        User.Name = Console.ReadLine();
        Console.WriteLine("Введите фамилию: ");
        User.LastName = Console.ReadLine();
        Console.WriteLine("Введите логин: ");
        User.Login = (Console.ReadLine());
        Console.WriteLine("Длина Логина: {0}", User.Login.Length);
        Console.WriteLine("Есть ли у вас животные? Да или Нет");
        var result = Console.ReadLine();
        if (result == "Да")
        {
            User.Pet = true;
        }
        else
        {
            User.Pet = false;
        }
        Console.WriteLine("Введите возраст пользователя: ");
        User.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите ваши 3 любимых цвета ");
        User.colors = new string[3];
        for (int i = 0; i < User.colors.Length; i++)
        {
            User.colors[i] = Console.ReadLine();
        }
    }

}
//

