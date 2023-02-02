internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write(" введите любое число ");
    int number = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    int ind = 2;
    if (number>99)
    {
      int third = number.ToString()[ind] - '0';
      Console.WriteLine(third);
    }
    else
    {
      Console.WriteLine("третьей цифры нет");
    }
    
  }
}

