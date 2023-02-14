Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
RandomNum(numbers);
Console.WriteLine("Рандомный массив: ");
PrintArray(numbers);
int sum = 0;

for (int j = 0; j < numbers.Length; j+=2)
    sum += numbers[j];

    Console.WriteLine($"всего {numbers.Length} чисел, сумма нечетных элементов  = {sum}");

void RandomNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}