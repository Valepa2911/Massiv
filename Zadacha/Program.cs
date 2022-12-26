// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

string[] array = new string[8] { "14", "hello", "daccc", "2", "777", "dsaFD", "258963", "World" };
string[] ar2 = new string[array.Length];
Vivod(array);
void Vivod(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(" " + array[i]);
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    int count = 0;
    if (array[i].Length <= 3)
    {
        ar2[count] = array[i];
        count++;
        
    }
    Console.WriteLine(ar2[count]);

}




