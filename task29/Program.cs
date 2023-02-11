int Pr(string mes)
{
  System.Console.Write(mes);
  string ReadInput = System.Console.ReadLine();
  int result = int.Parse(ReadInput);
  return result;
}

int[] GenArr(int length , int minValue, int maxValue)
{
  int[] array = new int[length];
  Random random = new Random();
  for (int i = 0; i < length; i++)
  {
    array[i] = random.Next(minValue, maxValue + 1);
  }
  return array;
}

void PrintArr(int[] array)
{
  System.Console.Write("i");
  for (int i = 0; i < array.Length - 1; i++)
  {
    System.Console.Write ($"{array[i]}");
  }
  System.Console.Write ($"{array[array.Length - 1]}");
  System.Console.Write ("i");
}


PrintArr(array);