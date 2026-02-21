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
