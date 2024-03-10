using System;

class Program
{
    static void Main()
    {
        string input = "Hello, world!";
        string reversed = ReverseString(input);
        Console.WriteLine(reversed);
    }

    static string ReverseString(string input)
    {
        char[] chars = input.ToCharArray();
        int left = 0;
        int right = chars.Length - 1;

        while (left < right)
        {
            char temp = chars[left];
            chars[left] = chars[right];
            chars[right] = temp;
            left++;
            right--;
        }

        return new string(chars);
    }
}
