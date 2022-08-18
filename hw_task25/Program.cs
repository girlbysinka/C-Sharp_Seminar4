/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Clear();

int userNumber1 = PrintNumber();
int userNumber2 = PrintNumber();

double degree = Math.Pow(userNumber1, userNumber2);
Console.WriteLine (degree);


int PrintNumber()
    {
    int userNumber = new int();
    Console.WriteLine("Введите пятизначное число:");
    userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
    }