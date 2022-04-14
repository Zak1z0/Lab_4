using System;

namespace _1
{
    class Program
    {
        static string first(string text)
        {
            char[] array = text.ToCharArray();
            string text1 = "";
            string text2 = "";
            for (int i = 0; i < array.Length; ++i)
            {
                if (i == ' ')
                {
                    break;
                }
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if (j == ' ')
                    {
                        break;
                    }
                    if (array[i] == array[j])
                    {
                        text1 += array[j];

                        break;
                    }
                }
            }
            int k;
            for (int i = 0; i < array.Length; ++i)
            {
                k = 0;
                for (int j = 0; j < text1.Length; j++)
                {
                    if (array[i] == text1[j])
                    {
                        k = 1;
                    }

                }
                if (k == 0)
                {
                    text2 += array[i] + " ";
                }
            }
            return text2;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, обязательно завершите его точкой:");
            string pred = Console.ReadLine().ToUpper();
            char[] arrey = pred.ToCharArray();
            while (pred == "")
            {
                Console.WriteLine("Введите предложение, обязательно завершите его точкой:");
                pred = Console.ReadLine().ToUpper();
                arrey = pred.ToCharArray();
            }
            while (arrey[^1] != '.')
            {
                Console.WriteLine("С точкой на конце пожалуйста):");
                pred = Console.ReadLine();
                arrey = pred.ToCharArray();
                while (pred == "")
                {
                    Console.WriteLine("Введите предложение, обязательно завершите его точкой:");
                    pred = Console.ReadLine().ToUpper();
                    arrey = pred.ToCharArray();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Первый способ");

            Console.WriteLine(first(pred));

            Console.WriteLine();
            Console.WriteLine("Второй способ");


            string ansver = "";
            for (int i = 0; i < pred.Length; i++)
            {
                if (pred.IndexOf(pred[i]) == pred.LastIndexOf(pred[i]))
                {
                    ansver += pred[i] + " ";
                }
            }
            Console.WriteLine(ansver);
        }
    }
}
