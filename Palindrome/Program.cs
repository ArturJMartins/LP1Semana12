using System;
using System.Collections.Generic;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine($"{s} -> {Palindromo(s)}");
            }
        }

        public static bool Palindromo(string palavra)
        {
            if (palavra == null)
            {
                throw new ArgumentNullException(nameof(palavra));
            }

            if(palavra.Length < 2)
            { 
                return true;
            }

            Queue<char> queue = new Queue<char>();
            Stack<char> stack = new Stack<char>(); 
            
            foreach (char c in palavra)
            {
                queue.Enqueue(c);
                stack.Push(c);
            }

            while (queue.Count > 0)
            {
                if(queue.Dequeue() != stack.Pop())
                {
                    return false;
                }
            }

            return true;      
            
        }
    }
}
