/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Clear();

int userNumber = PrintNumber();
GetSumDigits (userNumber);

    
int GetSumDigits (int number)
    {        
        int remainder = number % 10;
        int quotient = number / 10;
        int sum = remainder;
        int count = 0;
        
        while (quotient > 0)
            {
                remainder = quotient % 10;
                sum = sum + remainder;
                quotient = quotient / 10;
                count++;
            }

        Console.WriteLine($"Сумма цифр в введённом числе равна {sum}");
        return sum;
    }


int PrintNumber()
    {
    int userNumber = new int();
    Console.WriteLine("Введите пятизначное число:");
    userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
    }