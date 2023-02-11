
    internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write(" введите целое число1 ");
    int N1 = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    Console.Write(" введите целое число2 ");
    int N2 = int.Parse(Console.ReadLine());
    double power = Math.Pow(N1,N2);
    Console.WriteLine($"Возводим в степень и получаем {power}");
  }

}  
   
    
    
   

  


