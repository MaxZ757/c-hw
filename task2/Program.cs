internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write("введите число1: ");
    int number1 = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    Console.Write("введите число2: ");
    int number2 = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    if (number1 > number2)
    {
      Console.WriteLine("max = " + number1 + " min = " + number2);
    
    }
    else
    {
      Console.WriteLine("max = " + number2 + " min = " + number1);
    }
  }
}