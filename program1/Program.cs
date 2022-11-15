/* Задача: Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

string[] array = new string[6] {"hello","2","world","123","-3","computer science"};
string[] array1 = new string[array.Length];

void NextStringArray(string[] array, string[] array1)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array1[index] = array[i];
        index++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     Console.Write($"{array[i]} ");
    }
     Console.WriteLine();
}

NextStringArray(array,array1);
PrintArray(array1);
           