
public class StudentDirectory
{
    public Dictionary<int, string> Students { get; set; }
 
    public StudentDirectory()
    {
        Students = new Dictionary<int, string>();
    }
 
    public void AddStudent(int id, string name)
    {
        Students.Add(id, name);
    }
    public override string ToString()
    {
        string result = "Student Directory:\n";
        foreach (KeyValuePair<int, string> entry in Students)
        {
            result += $"ID: {entry.Key} , Name: {entry.Value}\n";
        }
        return result;
    }
}