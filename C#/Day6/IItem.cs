
namespace Day6
{
    public interface IItem
    {
        int Id{get; set;}
        string Title{get; set;}
        string GetInfo();
    }
}