/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
(на примерах демонстрация выводов 5 и 3 размерных массивов, вам же нужно сделать 8)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();

int[] array = new int[8];
GetRandomArray (array);


void GetRandomArray (int[] array)
    {
        for (int i=0; i < array.Length; i++)
        {
            array[i] = new Random().Next();
            Console.Write($"{array[i]} ");
        }
    }