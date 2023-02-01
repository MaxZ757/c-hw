internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write("введите номер дня недели от 1 до 7 (пн-вск) ");
    int number = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    if (number >= 1 & number <=5)
    {
      Console.WriteLine($" {number}  -> нет");
    }
    else
    {
      if (number == 6  || number == 7)
      {
        Console.WriteLine($" {number}  -> да");
      }
      else
      {
        Console.WriteLine($" не то число ");
      }

    }
    
  }
}

