namespace _6
{
    internal class Pen
    {
        string Color;
        int Cost;

        public Pen()
        {
            Color = "Черный";
            Cost = 100;
        }
        public Pen (string color, int cost)
        {
            this.Color = color;
            this.Cost = cost;
        }
    }
}
