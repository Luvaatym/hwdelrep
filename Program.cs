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
}
public static string GetChessCellColor(int x, int y)
{
    if (x < 1 || x > 8 || y < 1 || y > 8)
        throw new ArgumentOutOfRangeException("Координаты должны быть от 1 до 8.");

    return (x + y) % 2 == 0 ? "Черная" : "Белая";
}
/*Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8). Учитывая, что левое нижнее поле доски (1, 1) является черным, вывести, какой цвет имеет поле с данными координатами.*/