using System;

namespace _3
{
    class Program
    {
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
            string result = "";
            for (int i = pred.Length - 1; i >= 0; i--)
            {
                //if (pred[i] == ' ')
                //{
                //    for (int x = i + 1; x == ' '; x++)
                //    {
                //        result += pred[x];
                //        if (pred[x] == '.' || pred[x] == ' ')
                //        {
                //            break;
                //        }

                //    }
                //}
                Console.Write(pred[i] + "");
            }
            Console.WriteLine(result);
        }
    }
}
