using System;
using System.Threading;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    

            

           

            Console.ReadLine();
        }


        class Rectangle
        {
            private float _width;
            private float _height;
           
            public Rectangle(float width, float height)
            {
                _width = width;
                _height = height;             
            }

            public float Width
            {
                get { return _width;}
                set { _width = value; }
            }
        }
              
    }
}






