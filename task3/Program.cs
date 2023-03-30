// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] array = new int[4];
int min = 0;
int max = 0;

for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(1,100);
 
  if( max < array[i])
  {
    max = array[i];
  }
  else 
  {
    min = array[i];
  }
}

//Console.WriteLine($"Минимальное число: " +min);
//Console.WriteLine($"Максимальное число: " +max);

Console.WriteLine(string.Join("  ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементом равна: " +(max-min));