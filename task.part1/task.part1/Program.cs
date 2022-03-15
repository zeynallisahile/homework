using System;

namespace task.part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metni daxil edin:");
            string Sentence = Console.ReadLine();
            int First = Sentence.IndexOf(' ');
            int Last = Sentence.LastIndexOf(' ');
            int value = Last - First;
            Console.WriteLine(Sentence.Remove(First,value));
            
        }    
      }
    }
