using Tyuiu.KovalenkoMA.Sprint0.Task2.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        // Вызов класса DataService и метода GetMessage
        // из библиотеки Tyuiu.KovalenkoMA.Sprint0.Task2.V0.Lib
        Console.WriteLine(DataService.GetMessage("Margo"));
        Console.ReadKey();
        Console.ReadKey();
    }
}