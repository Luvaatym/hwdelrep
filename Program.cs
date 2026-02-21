using System;

public class Program
{
    public static void Main()
    {
    }

    /*Дано трехзначное число. Обнулить в нем разряд десятков.*/
    public static int RemoveTensDigit(int number)
    {
        if (number < 100 || number > 999)
            throw new ArgumentException("Число должно быть трехзначным.");

        int hundreds = number / 100;
        int ones = number % 10;

        return hundreds * 100 + ones;
    }

    public static string GetChessCellColor(int x, int y)
    {
        if (x < 1 || x > 8 || y < 1 || y > 8)
            throw new ArgumentOutOfRangeException("Координаты должны быть от 1 до 8.");

        return (x + y) % 2 == 0 ? "Черная" : "Белая";
    }
    /*Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8). Учитывая, что левое нижнее поле доски (1, 1) является черным, вывести, какой цвет имеет поле с данными координатами.*/
    public static int CountRealRoots(double a, double b, double c)
    {
        if (a == 0)
            throw new ArgumentException("A не может быть 0.");

        double d = b * b - 4 * a * c;

        if (d > 0) return 2;
        if (d == 0) return 1;
        return 0;
    }
    /*Даны числа 𝐴, 𝐵, 𝐶 (число 𝐴 не равно 0). Вернуть количество вещественных корней квадратного уравнения 𝐴𝑥2+𝐵𝑥+𝑐=0.*/
    public static double Min(double a, double b)
    {
        return a < b ? a : b;
    }
    /*Создать функцию, которая возвращает минимум из двух переданных вещественных чисел. */
    public static double ProductOfEvenNumbers(int a, int b)
    {
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        double product = 1;
        bool hasEven = false;

        for (int i = a; i <= b; i++)
        {
            if (i % 2 == 0)
            {
                product *= i;
                hasEven = true;
            }
        }

        return hasEven ? product : 0;
    }
    /*Даны целые числа A и B. Найти произведение всех чётных целых чисел от A до B включительно.*/
    public static (int lessThanK, int divisibleByK) AnalyzeNumbers(int k, params int[] numbers)
    {
        int lessCount = 0;
        int divisibleCount = 0;

        foreach (int num in numbers)
        {
            if (num == 0)
                break;

            if (num < k)
                lessCount++;

            if (num % k == 0)
                divisibleCount++;
        }

        return (lessCount, divisibleCount);
    }
    /*Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0. Вычислить количество чисел в наборе, меньших K, а также количество чисел, делящихся на K нацело*/
    public enum Seasons
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }

    public static Seasons GetSeason(int month)
    {
        if (month < 1 || month > 12)
            throw new ArgumentOutOfRangeException("Месяц должен быть от 1 до 12.");

        return month switch
        {
            12 or 1 or 2 => Seasons.Winter,
            3 or 4 or 5 => Seasons.Spring,
            6 or 7 or 8 => Seasons.Summer,
            _ => Seasons.Autumn
        };
    }
    /*Описать перечислимый тип Seasons (времена года). Создать метод, который по номеру месяца [1..12] возвращает время года.*/
    public static void PrintRandomMonths(int n)
    {
        if (n <= 0)
            throw new ArgumentException("N должно быть положительным.");

        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            int month = random.Next(1, 13);
            Seasons season = GetSeason(month);

            Console.WriteLine($"Месяц №{month}, его сезон: {season}");
        }
    }
    /*Описать метод, выводящий на консоль N строк "Месяц №<номер месяца>, его сезон: <сезон для этого месяца>". Номера месяцев генерируются случайно.*/
}