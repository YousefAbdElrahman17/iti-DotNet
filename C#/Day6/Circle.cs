
namespace Day6
{
    public class Circle : IShape
    {
        float PI = 3.14f;
        public float Raduis{get; set;}
        public Circle(float Raduis)
        {
            this.Raduis = Raduis;
        }
        public float GetArea()
        {
            return PI*Raduis*Raduis;
        }
        public string GetInfo()
        {
            return $"Circle: Raduis = {Raduis}";
        }
        public override string ToString()
        {
            return $"{GetInfo()} Area = {GetArea()}";
        }
    }
}