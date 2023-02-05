internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write(" введите x1 ");
    double distance;
    int x1 = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    Console.Write(" введите x2 ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write(" введите y1 ");
    int y1 = int.Parse(Console.ReadLine());
    Console.Write(" введите y2 ");
    int y2 = int.Parse(Console.ReadLine());
    Console.Write(" введите z1 ");
    int z1 = int.Parse(Console.ReadLine());
    Console.Write(" введите z2 ");
    int z2 = int.Parse(Console.ReadLine());
    distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    //double result = Math.Round(Math.Sqrt(x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1),2);
    distance = Math.Round(distance, 2);
    Console.WriteLine($"Расстояние между точками равно {distance}");
  }
}


