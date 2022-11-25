// Урок 3. Базовые алгоритмы. Продолжение


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*static bool IsPalindrome(string s)
{
    for (int i = 0; i < s.Length / 2; ++i)
        if (s[i] != s[s.Length - 1 - i]) return false;
        Console.WriteLine("ложь");
    return true;
    Console.WriteLine("правда");
}
*/

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*static void Main(string[] args)
    {
        char selection;
        Double x1, x2, y1, y2, z1, z2, distance;

        Console.WriteLine("1. Расстояние между двумя точками на плоскости.");
        Console.WriteLine("2. Расстояние между двумя точками в пространстве.");
        Console.WriteLine("Выберите нужный пункт (1 или 2):");

        selection = Convert.ToChar(Console.ReadLine());

        switch (selection)
        {
            case '1':
                Console.Write("Введите координаты x1: ");
                x1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты x2: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты y1: ");
                y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты y2: ");
                y2 = Convert.ToDouble(Console.ReadLine());

                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
                Console.ReadKey();
                break;
            case '2':
            Console.Write("Введите координаты x1: ");
                x1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты x2: ");
                x2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты y1: ");
                y1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты y2: ");
                y2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты z1: ");
                z1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите координаты z2: ");
                z2 = Convert.ToDouble(Console.ReadLine());

                distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
                Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("Вы ввели неверный символ");
                Console.ReadKey();
                break;
        }
*/

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*void SqrOl(int N)
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine($"{i} -> {i * i}");
    }
}
Console.Write ("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());
SqrOl(N);
*/