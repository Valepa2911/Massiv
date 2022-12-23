// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.WriteLine("строка массива");
int mas = Convert.ToInt32 (Console.ReadLine());
string[] array = new string[mas];
string[] ar2 = new string[array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length<=0)
    {
          ar2[count] = array[i];
          count++;
    }
    Console.WriteLine(ar2[count]);
}







