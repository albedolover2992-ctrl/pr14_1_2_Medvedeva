using System;
using System.Collections.Generic;
namespace Практическая_14._Алгоритмизация
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Stack<int> nums = new Stack<int>(n);
                for (int i = 1; i <= n; i++)
                {
                    nums.Push(i);
                }
                Console.WriteLine($"n = {n}" +
                    $"\nРазмерность стека: {nums.Count}" +
                    $"\nВверхний элемент стека: {nums.Peek()}"+ 
                    $"\nРазмерность стека: {nums.Count}" +
                    $"\nСодержимое стека: ");
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($"{nums.Pop()} ");
                }
                nums.Clear();
                Console.WriteLine($"\nНовая размерность стека: {nums.Count}");
  
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка");
            }
       }
    }
}
