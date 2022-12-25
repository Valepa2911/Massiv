// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

Console.WriteLine("строка массива");
int mas;
int.TryParse(Console.ReadLine(), out mas);
string[] array = new string[mas];
string[] ar2 = new string[array.Length];

for (int i = 0; i < array.Length; i++)
{
    int count = 0;
    if (array[i].Length <= 3)
    {
        ar2[count] = array[i];
        count++;
    }
    Console.WriteLine(string.Join(",",ar2[count]));
}







