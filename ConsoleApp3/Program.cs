Console.WriteLine("Введите ваше имя: ");
string name = Console.ReadLine();
Console.WriteLine("Введите ваш возраст: ");
byte age = (byte)int.Parse(Console.ReadLine());
Console.WriteLine("Вас зовут {0} и вам {1} года(лет)", name, age);
Console.WriteLine("Введите дату вашего Дня Рождения: ");
string birthday = Console.ReadLine();
Console.WriteLine("Дата вашего дня рождения: {0}", birthday);
Console.ReadKey();