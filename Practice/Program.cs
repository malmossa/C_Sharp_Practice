using System;
using System.Threading;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Score user1 = new("Mansor", 12420, 15);
           

            

           

            Console.ReadLine();
        }
        
        class Score
        {
            public string _name;
            public int _points;
            public int _level;

            

            public Score(string name, int points, int level)
            {
                _name = name;
                _points = points;
                _level = level;
            }

           
        }
    }
}






