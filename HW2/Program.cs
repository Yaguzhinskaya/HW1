// Урок 2. Базовые алгоритмы


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8 (2 задача)
// 918 -> 1

/*
void chislo (int num)
{
  int ed = num % 10;
  int dec = num / 10;
  int sot = num / 100;
  int rez = (num / sot) % 10;
  num = Convert.ToInt32(Console.ReadLine());
  chislo(num);
}
*/


// Console.Write($"Ваше число {num} это его второе {rez}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*int ThirdDigit(int number)
    {
        if (number >=100)
    {
        while (number > 999)
            {
                 number = number / 10;
            }
        int result = number % 10;
    }
else
{
    int result = -1; 
}
Console.WriteLine($"");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

/*Console.WriteLine("Ведите числo");
int num = Convert.ToInt32(Console.ReadLine());
{
    if (num == 1)
    Console.WriteLine("Нет, это понедельник");
    if (num == 2)
    Console.WriteLine("Нет, это вторник");
    if (num == 3)
    Console.WriteLine("Нет, это среда");
    if (num == 4)
    Console.WriteLine("Нет, это четверг");
    if (num == 5)
    Console.WriteLine("Нет, это пятница");
    if (num == 6)
    Console.WriteLine("да, это суббота наш долгожадынный выходной!");
    if (num == 7)
    Console.WriteLine("да, это воскресенье, но не раслабляйся завтра снова понедельник");
    if (num < 1 && num > 7)
    Console.WriteLine("Ведите числo от 1 до 7");
}
*/