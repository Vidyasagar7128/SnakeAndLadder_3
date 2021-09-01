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
            int rand = new Random().Next(1, 7);
            Console.WriteLine($"Dies is : {rand}");
        }
        
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.firstDies();
        }
    }
}
