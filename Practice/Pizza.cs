
namespace Practice
{
    internal class Pizza
    {
        string bread;
        string sauce;
        string cheese;
        string topping;

        internal Pizza (string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        internal Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;         
        }
    }
}
