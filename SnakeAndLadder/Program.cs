using System;
using System.Collections.Generic;

namespace SnakeAndLadder
{
    class Program
    {
        int user1 = 0;
        int count = 0;
        List<int> countStop1 = new List<int>();
        void firstDies()
        {
            Console.WriteLine("Snake And Ladders...");
        }
        
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.firstDies();
        }
    }
}
