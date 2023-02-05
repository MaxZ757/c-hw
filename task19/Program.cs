internal class Program
{
  private static void Main(string[] args)
  {
    Console.Clear();
    Console.Write(" введите любое пятизначное число ");
    int number = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
    int ind1 = 0;
    int ind2 = 1;
    int ind4 = 3;
    int ind5 = 4;
    int first = number.ToString()[ind1] - '0';
    int sec = number.ToString()[ind2] - '0';
    int fourth = number.ToString()[ind4] - '0';
    int fifth = number.ToString()[ind5] - '0';
    if (first ==  fourth && sec == fifth)
    {
      Console.WriteLine(" -> да");
    }
    else
    {
      if (first ==  fifth && sec == fourth)
      {
        Console.WriteLine(" -> да");
      }
      else
      {
        Console.WriteLine(" -> нет");
      }
    }
    
  }
}

