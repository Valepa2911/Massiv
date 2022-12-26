// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

string[] array = { "14", "hello", "d=)", "2", "777", "dsaFD", "258963", "World" };
string[] ar2 = new string[array.Length];
int b = 3;
Vivod(array);

void Vivod(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
    }
    Console.WriteLine();
}


for (int i = 0; i < array.Length; i++)
{


    if (array[i].Length <= b)
    {
        ar2[i] = array[i];

    }
    else
        ar2[i] = String.Empty;
    Console.Write(" " + ar2[i]);

}








