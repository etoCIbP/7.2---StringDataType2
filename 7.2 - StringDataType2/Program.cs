using System;

namespace _7._2___StringDataType2
{
    class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            Console.WriteLine("Текст: ");
            string text = Console.ReadLine();

            char[] arr = text.ToCharArray();
            for (int i = 0; i < arr.Length; ++i) arr[i] = (((int)arr[i] >= (int)'А' && (int)arr[i] <= 'Я') || ((int)arr[i] >= 'а' && (int)arr[i] <= 'я')) ? '*' : arr[i];
            text = new string(arr);
            Console.WriteLine(text);

        }
    }
}
