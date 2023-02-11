
    Console.Clear();
    Console.Write(" введите целое число ");
    int n = int.Parse(Console.ReadLine()); // перевод из строковой в числовой формат
   
    Console.WriteLine($"Сумма числа {GetSum(n)}");
   int GetSum(int num)
    {
      int count = Convert.ToString(num).Length;
      int temp = 0;
      int result = 0;
      for (int i = 0; i <= count; i++)
      {
        temp = num - num % 10;
        result = result + (num - temp);
        num = num / 10;

      }
      return result; 
    }
    




