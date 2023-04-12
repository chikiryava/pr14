using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pract14
{
    class Program
    {
        static int CheckNumber()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    if (result <= 1)
                        Console.WriteLine("Введите число больше 1");
                    else
                        return result;
                }
                Console.WriteLine("Вы ввели не число");
                        
                
            }
        }
        static void Zadanie1()
        {
            Stack<int> number = new Stack<int>();
            Console.WriteLine("Введите число n");
            int n = CheckNumber();
            for(int i = 1; i <= n; i++)
                number.Push(i);
            Console.WriteLine($"Размерность стека = {number.Count}");
            Console.WriteLine($"Верхний элемент стека = {number.Peek()}");
            Console.Write("Содержимое стека = ");
            while (true)
            {
                Console.Write($"{number.Pop()} ");
                if (number.Count == 0)
                    break;
            }
            Console.WriteLine($"\nНовая размерность стека = {number.Count}");
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
        }
        static void Zadanie2()
        {
            Console.WriteLine("Введите пример");
            string mathematicalExpression = 
        }
        static string CheckExpression()
        {
            while (true)
            {
                bool expressionIsRight = false;
                string expression = Console.ReadLine();
                foreach(char i in expression)
                {
                   
                }
                var check = 
            }
        }
    }
}
