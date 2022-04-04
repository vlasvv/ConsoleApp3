class Programm
{
    static void Main(string[] args)
    {
        string? a = Console.ReadLine(); ;
        double b = Convert.ToDouble(a);
        double result = 0;
        double value = 100;


        result = b / value;
        Console.WriteLine("Result: " + result + " metr");



        Console.ReadKey();
    }
}