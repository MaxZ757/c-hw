internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write("введите число: ");
    int N = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    int S = 2;
    if (N > 1)
    {
      while (S <= N)
      if (S%2==0)
      {
        Console.WriteLine(S++);
      }
      else
      {
        Console.WriteLine(" ");
        S= S + 1;
      }
    
    }
    else
    {
      Console.WriteLine("negative");
    }
  }
}
