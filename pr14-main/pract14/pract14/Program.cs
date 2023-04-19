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
            //Zadanie1();
            Zadanie2();
            Console.ReadKey();
        }
        static void Zadanie2()
        {
            Console.WriteLine("Введите пример");
            string expression = CheckExpression(Console.ReadLine());
            Console.WriteLine(expression);

        }
        static string CheckExpression(string expression)
        {
            Stack<char> test = new Stack<char>();
            foreach (char e in expression)
            {
                test.Push(e);
            }
            bool rightparenthesis = false;
            string exp = string.Empty;
            int k = 0;
            int i = 0;
            while(test.Count!=0)
            {
                try
                {
                    char characher = test.Pop();

                    if (i == 0 && characher == '(')
                    {
                        Console.WriteLine($"В позиции {i} возможно лишнаяя скобка 1");
                        i++;
                        continue;
                    }
                    else if (characher == '(' && exp[exp.Length - 1] == ')')
                    {
                        exp = exp.Remove(exp.Length - 1, 1);
                        Console.WriteLine($"Обнаружены пустые скобочки в позиции {k} 2");
                        rightparenthesis = false;
                        i++;
                        continue;
                    }
                    else if (characher == ')' && exp[exp.Length - 1] == ')')
                    {
                        exp = exp.Remove(exp.Length - 1, 1);
                        Console.WriteLine($"Обнаружены пустые скобочки в позиции {k} 3");
                        rightparenthesis = false;
                        i++;
                        continue;
                    }
                    else if (characher == ')')
                    {
                        rightparenthesis = true;
                        k = i;
                    }

                    else if (characher == '(' && rightparenthesis == false)
                    {
                        Console.WriteLine($"В позиции {i} возможно лишнаяя скобка 4");
                        i++;
                        continue;
                    }
                    else if (characher == '(' && rightparenthesis == true)
                    {
                        rightparenthesis = false;
                    }

                    exp += characher;
                    i++;
                }
                catch (Exception)
                {
                    continue;
                }
            }
           
            if (rightparenthesis == true)
            {
                Console.WriteLine($"Недостающая скобка ");
                exp += '(';
            }
            if (exp[0] == '(')
                exp = exp.Remove(0, 1);
            char[] str = exp.ToCharArray();

            return new string(str.Reverse().ToArray());
           
               

        }
    }
}
