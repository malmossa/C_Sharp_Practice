
namespace Practice
{
    public class Planet
    {
        private int _id;
        private int _radius;

        public string Name { get; set; }
        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
    }
}
