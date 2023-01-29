internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write("введите число: ");
    int number = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    if (number%2 == 0)
    {
      Console.WriteLine("yes");
    
    }
    else
    {
      Console.WriteLine("no");
    }
  }
}
