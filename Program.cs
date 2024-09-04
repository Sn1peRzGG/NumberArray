using System;
using System.Text;

class Program
{
    static Random random = new Random();

    static void Main()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        int arrayLength = 10;

        string[] array = new string[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            array[i] = GenerateRandomString(8);
        }

        Console.WriteLine("Масив випадкових рядків:");
        foreach (var str in array)
        {
            Console.WriteLine(str);
        }
    }
    static string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] stringChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        return new string(stringChars);
    }
}
