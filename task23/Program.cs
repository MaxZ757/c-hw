internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write(" введите целое число ");
    int N = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    int counter = 1;
    while (counter < N)
    {
      Console.Write((Math.Pow(counter,3)) + ", ");
      counter++;
    }
    Console.WriteLine((Math.Pow(counter,3)) + ", ");
  }
}



