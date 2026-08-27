namespace Day6
{
    public class Square : IShape
    {
        public float Side { get; set; }
        public Square(float Side)
        {
            this.Side = Side;
        }
        public float GetArea()
        {
            return Side * Side;
        }
        public string GetInfo()
        {
            return $"Square: Side = {Side}";
        }
        public override string ToString()
        {
            return $"{GetInfo()} Area = {GetArea()}";
        }
    }
}
 