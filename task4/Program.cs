internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write("введите число1: ");
    int number1 = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    Console.Write("введите число2: ");
    int number2 = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    Console.Write("введите число3: ");
    int number3 = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    if (number1 > number2)
    {
      if (number1 > number3)
        {
          Console.WriteLine(number1);
        }
      else
      {
        Console.WriteLine(number3);
      }
        
      
    
    }
    else
    {
      if (number2 > number3)
      {
        Console.WriteLine(number2);
      }
      else
      {
        Console.WriteLine(number3);
      }
    }
  }
}
