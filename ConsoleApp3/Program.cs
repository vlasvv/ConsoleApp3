class Program
{
    public static void SignUp()
    {
        (string Name, string SurName, string[] colors, int Age, string[] NamePet) User;
        Console.WriteLine("Введите своё имя: ");
        User.Name = Console.ReadLine();
        Console.WriteLine("Введите фамилию: ");
        User.SurName = Console.ReadLine();
        User.Age = CheckAge();

        Console.WriteLine("Есть ли у вас животные? Да или Нет");
        var result = Console.ReadLine();
        if (result == "Да")
        {
            Pets();
        }
        Color();
        Console.WriteLine(User.Name, User.SurName, User.colors, User.Age);


        string[] Color()
        {
            string temp;
            int num;
            int countColor;
            do
            {
                Console.WriteLine("Введите кол-во цветов: ");
                temp = Console.ReadLine();
            } while (CheckNum(temp, out num));
            countColor = Convert.ToInt32(temp);
            User.colors = new string[countColor];
            for (int i = 0; i < User.colors.Length; i++)
            {
                Console.WriteLine("Введите ваш любимый цвет: ");
                User.colors[i] = Console.ReadLine();
            }
            return User.colors;
        }


        string[] Pets()
        {



            string temp;
            int num;
            int countPets;
            do
            {
                Console.WriteLine("Введите кол-во питомцев: ");
                temp = Console.ReadLine();
            } while (CheckNum(temp, out num));
            countPets = Convert.ToInt32(temp);
            User.NamePet = new string[countPets];
            for (int i = 0; i < User.NamePet.Length; i++)
            {
                Console.WriteLine("Введите кличку питомца: ");
                User.NamePet[i] = Console.ReadLine();
            }

            return User.NamePet;
        }
        int CheckAge()
        {
            string temp;
            int num;
            int countAge;
            do
            {
                Console.WriteLine("Введите свой возраст: ");
                temp = Console.ReadLine();
            } while (CheckNum(temp, out num));
            countAge = Convert.ToInt32(temp);
            return countAge;
        }
        static bool CheckNum(string number, out int corrumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrumber = intnum;
                    return false;
                }
            }
            {
                corrumber = 0;
                return true;
            }
        }

    }

    static void Main(string[] args)
    {
        SignUp();

    }
}
