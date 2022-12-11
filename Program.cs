// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1 = new string[10] { "vr44g", "dbs4", "dd", "4yh", "5gggg", "3", "defhg", "987", "m8", "0975erfdg" };
string[] array2 = new string[array1.Length];

void NewArray(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length < 4)
        {
            array2[j] = array1[i];
            j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}
NewArray(array1, array2);
PrintArray(array2);