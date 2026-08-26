using System;
 
class Manager : FullTimeEmployee
{
    public int TeamSize { get; set; }
 
    public Manager(int id, string name, float salary, string department, int teamSize) : base(id, name, salary, department)
    {
        TeamSize = teamSize;
    }
 
    public override string ToString()
    {
        return $"{base.ToString()} \nTeam Size: {TeamSize}";
    }
}
