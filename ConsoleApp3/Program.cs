class Programm
{
    
    static void Main(string[] args) {
        if (Console.BackgroundColor == ConsoleColor.Black)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
        }



        }
    enum Semaphore
    {
        Green = 100,
        Yellow = 200,
        Red = 300,
    }
}
