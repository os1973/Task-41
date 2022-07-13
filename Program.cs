/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


int [] arrayNumbers = new int[M];

void InputNumbers(int M)
{
    for (int i = 0; i < M; i++)
    {
    Console.Write($"Введите {i+1} чисел: ");
    }
}

int Comparison(int[] arrayNumbers)
{
  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if(arrayNumbers[i] > 0 ) 
    {
    count += 1;
    } 
  }
  return count;
}

InputNumbers(M);

Console.WriteLine($"Чисел больше 0: {Comparison(arrayNumbers)} ");