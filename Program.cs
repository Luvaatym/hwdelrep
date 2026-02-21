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
}