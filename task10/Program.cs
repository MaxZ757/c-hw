internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write("введите трехзгачное число: ");
    int number = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    int a1 = number / 10;
    int a2 = a1 % 10;
    Console.WriteLine(a2);
    
  }
}

