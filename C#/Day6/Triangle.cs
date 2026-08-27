namespace Day6
{
    public class Triangle : IShape
    {
        float TriHalf = 0.5f;
        public float BaseLength { get; set; }
        public float Height { get; set; }
 
        public Triangle(float BaseLength, float Height)
        {
            this.BaseLength = BaseLength;
            this.Height = Height;
        }
        public float GetArea()
        {
            return TriHalf * BaseLength * Height;
        }
        public string GetInfo()
        {
            return $"Triangle: Base = {BaseLength} , Height = {Height}";
        }
        public override string ToString()
        {
            return $"{GetInfo()} Area = {GetArea()}";
        }
    }
}
 

