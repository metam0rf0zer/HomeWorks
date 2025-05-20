using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст для шифрования (на латинском):");
        string input = Console.ReadLine();

        string encrypted = AtbashEncrypt(input);

        Console.WriteLine("Зашифрованный текст:");
        Console.WriteLine(encrypted);

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static string AtbashEncrypt(string text)
    {
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];

            if (char.IsLetter(c))
            {
                bool isUpper = char.IsUpper(c);
                char upperChar = char.ToUpper(c);

                int offset = upperChar - 'A';
                char transformed = (char)('Z' - offset);

                result[i] = isUpper ? transformed : char.ToLower(transformed);
            }
            else
            {
                result[i] = c;
            }
        }

        return new string(result);
    }
}