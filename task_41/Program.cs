//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int Prompt(string massage)
{
  System.Console.Write(massage);
  string ReadInput = System.Console.ReadLine();
  int result = int.Parse(ReadInput);
  return result;
}
int[] Array(int length)
{
  int[] array = new int[length];
  for (int i = 0; i < length; i++)
  {
    array[i] = new Random().Next(-10, 10);

    Console.Write(array[i] + " ");
  }
  return array;
}
//int length = Prompt ("Введите число M:  ");
//int[] array = Array(length);

int CountPositive(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
   
  if (array[i] > 0)
  {
    count++;
  }
  return count;
}
int length = Prompt ("Введите число M:  ");
int[] array = Array(length);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0:  {CountPositive(array)}");
