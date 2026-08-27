
namespace Day6
{
    public class Rectangle : IShape
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Rectangle(float Width, float Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public float GetArea()
        {
            return Width * Height;
        }
        public string GetInfo()
        {
            return $"Rectangle: Width = {Width} , Height = {Height}";
        }
        public override string ToString()
        {
            return $"{GetInfo()} Area = {GetArea()}";
        }
    }
}