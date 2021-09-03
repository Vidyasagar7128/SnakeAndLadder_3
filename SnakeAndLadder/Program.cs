using System;
using System.Collections.Generic;

namespace SnakeAndLadder
{
    class Program
    {
        int user1 = 0;
        int count = 0;
        int user2 = 0;
        List<int> countStop1 = new List<int>();
        List<int> countStop2 = new List<int>();
        void firstDies()
        {
            while (this.user1 < 100)
            {
                int rand = new Random().Next(1, 7);
                this.user1 = this.user1 + rand;
                this.countStop1.Add(rand);
                Console.WriteLine($"Dies Roll ::::: {rand}");
                Console.WriteLine($"User 1 Reach : {this.user1}");
                if (this.user1 == 100 || this.user2 == 100)
                {
                    if(this.user1 == 100)
                    {
                        Console.WriteLine(":::::::::::::::::::::::Winner is USER 1:::::::::::::::::::::::::::");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(":::::::::::::::::::::::Winner is USER 2:::::::::::::::::::::::::::");
                        break;
                    }
                }
                ////////////Code for ladder
                ladderAndSnake(this.user1);
                while (this.user1 > 100)
                {
                    Console.WriteLine($"Greater than 100 Dies was : {this.countStop1[this.countStop1.Count-1]}");
                    this.user1 = this.user1 - this.countStop1[this.countStop1.Count - 1];
                    Console.WriteLine($"After Greater than 100 Position Will : {this.user1}");
                    break;
                }
                    this.count++;
                if (this.count % 2 == 0)
                {
                    secondDies();
                    break;
                }
            }
        }
        void secondDies()
        {
            while (this.user2 < 100)
            {
                int rand = new Random().Next(1, 7);
                this.user2 = this.user2 + rand;
                this.countStop2.Add(rand);
                Console.WriteLine($"Dies Roll ::::: {rand}");
                Console.WriteLine($"User 2 Reach : {this.user2}");
                ////////////Code for ladder and Snake
                ladderAndSnake(this.user2);
                while (this.user2 > 100)
                {
                    Console.WriteLine($"Greater than 100  Dies was : {this.countStop2[this.countStop2.Count - 1]}");
                    this.user2 = this.user2 - this.countStop2[this.countStop2.Count - 1];
                    Console.WriteLine($"After Greater than 100 Position Will : {this.user2}");
                    break;
                }
                this.count++;
                if (this.count % 2 != 0)
                {
                    firstDies();
                    break;
                }
            }
        }
        /// <summary>
        /// ////////////////////////Ladder snake
        /// </summary>
        void ladderAndSnake(int snakeladder)
        {
            if (snakeladder == 15)
            {
                Console.WriteLine($"From : {snakeladder}");
                this.user2 = 36;
                Console.WriteLine($"Ladder Pass : {snakeladder}");
            }
            if (snakeladder == 45)
            {
                Console.WriteLine($"From : {snakeladder}");
                snakeladder = 81;
                Console.WriteLine($"Ladder Pass : {snakeladder}");
            }
            if (snakeladder == 71)
            {
                Console.WriteLine($"From : {snakeladder}");
                snakeladder = 87;
                Console.WriteLine($"Ladder Pass : {snakeladder}");
            }
            ////////////Code for Snake
            if (snakeladder == 39)
            {
                Console.WriteLine($"From : {snakeladder}");
                snakeladder = 19;
                Console.WriteLine($"Snake Pass : {snakeladder}");
            }
            if (snakeladder == 72)
            {
                Console.WriteLine($"From : {snakeladder}");
                snakeladder = 29;
                Console.WriteLine($"Snake Pass : {snakeladder}");
            }
            if (snakeladder == 91)
            {
                Console.WriteLine($"From : {snakeladder}");
                snakeladder = 72;
                Console.WriteLine($"Snake Pass : {snakeladder}");
            }
        }
        /// ////////////////////////Ladder snake
        void show()
        {
            Console.WriteLine($"Dies Roll Out from User 1 :::::: {this.countStop1.Count} ::::: Times");
            Console.WriteLine($"Dies Roll Out from User 2 :::::: {this.countStop2.Count} ::::: Times");
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
