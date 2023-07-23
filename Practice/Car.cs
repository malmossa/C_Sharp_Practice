
namespace Practice
{
    internal class Car
    {   
        // Fields
        private string? _brand;
        private int _speed;
        
        
        // Constructors
        internal Car() 
        {
            Console.WriteLine("Instantiation a car");
        }
        
        
        // Properties
        internal string? Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        internal int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        // Methods
        internal void Accelerate()
        {
            _speed++;
        }
    }
}
