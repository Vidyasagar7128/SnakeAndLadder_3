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
            while (this.user1 < 100)
            {
                int rand = new Random().Next(1, 7);
                this.user1 = this.user1 + rand;
                this.countStop1.Add(rand);
                Console.WriteLine($"Dies Roll =========== {rand}");
                Console.WriteLine($"User 1 Reach : {this.user1}");
                ////////////Code for ladder
                if (this.user1 == 15)
                {
                    Console.WriteLine($"From : {this.user1}");
                    this.user1 = 36;
                    Console.WriteLine($"Ladder Pass : {this.user1}");
                }
                if (this.user1 == 45)
                {
                    Console.WriteLine($"From : {this.user1}");
                    this.user1 = 81;
                    Console.WriteLine($"Ladder Pass : {this.user1}");
                }
                if (this.user1 == 71)
                {
                    Console.WriteLine($"From : {this.user1}");
                    this.user1 = 87;
                    Console.WriteLine($"Ladder Pass : {this.user1}");
                }
                ////////////Code for Snake
                if (this.user1 == 39)
                {
                    Console.WriteLine($"From : {this.user1}");
                    this.user1 = 19;
                    Console.WriteLine($"Snake Pass : {this.user1}");
                }
                if (this.user1 == 72)
                {
                    Console.WriteLine($"From : {this.user1}");
                    this.user1 = 29;
                    Console.WriteLine($"Snake Pass : {this.user1}");
                }
                if (this.user1 == 91)
                {
                    Console.WriteLine($"From : {this.user1}");
                    this.user1 = 72;
                    Console.WriteLine($"Snake Pass : {this.user1}");
                }
                while (this.user1 > 100)
                {
                    Console.WriteLine($"Greater than 100 : {this.countStop1[this.countStop1.Count-1]}");
                    this.user1 = this.user1 - this.countStop1[this.countStop1.Count - 1];
                    Console.WriteLine($"After Greater than 100 Position Will : {this.user1}");
                    break;
                }

                    this.count++;
            }

        }
        void show()
        {
            Console.WriteLine($"Dies Roll Out {this.countStop1.Count} Times");
            Console.WriteLine($"Winning Position : {this.user1}");
                foreach(int i in this.countStop1)
            {
                Console.Write($"{i},");
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.firstDies();
            obj.show();
        }
    }
}
