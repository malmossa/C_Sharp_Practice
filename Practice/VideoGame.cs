
namespace Practice
{
    internal class VideoGame
    {
        private string _id;
        private string _name;
        private string _publisher;
        private string _rating;

        internal VideoGame(string name, string publisher, string rating)
        {
            _name = name;
            _publisher = publisher;
            _rating = rating;
        }

        internal string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
