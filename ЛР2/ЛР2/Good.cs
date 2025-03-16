namespace ЛР2
{
    public class Good
    {
        private string Name;
        private double Price;
        private Groups Group;

        public Good(string name, int price, Groups group)
        {
            Name = name;
            Price = price;
            Group = group;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetPrice()
        {
            return Price;
        }

        public Groups GetGroup()
        {
            return Group;
        }
    }
}
