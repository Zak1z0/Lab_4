using System;
using System.Linq;

namespace ConsoleApp2
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

            char[] str = pred.ToCharArray();
            string newstr = "";
            int j = 1;
            for (int i = 0; i < arrey.Length; ++i)
            {
                if ((arrey[i] == ' ') || (arrey[i] == '-') || (arrey[i] == ',') || (arrey[i] == '.'))
                {
                    if ((arrey[i - 1] == '-') || (arrey[i - 1] == ',') || (arrey[i - 1] == '.') || (arrey[i - 1] == ' '))
                    {
                        newstr += arrey[i];
                        newstr += " ";

                    }
                    else
                    {
                        newstr += "(" + j + ")" + arrey[i];
                        ++j;
                    }
                }
                else
                {
                    newstr += arrey[i];
                }
            }
            Console.WriteLine(newstr);


            int a = 0;
            string[] result = pred.Split(new string[] { " ", "." }, StringSplitOptions.RemoveEmptyEntries);
            string newtext = "";
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == "-")
                {
                    newtext += result[i] + " ";
                }
                else
                {
                    int number = a + 1;
                    newtext += result[i] + "(" + number + ")" + " ";
                    a++;
                }
            }
            Console.WriteLine(newtext + ".");
        }
    }
}
