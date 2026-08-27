namespace Day6
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public Student(int Id, string Name, string Email, int Age, float Grade)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Age = Age;
            this.Grade = Grade;
        }
        public override string ToString()
        {
            return $"Student: Id= {Id}, Name= {Name} , Email= {Email} , Age= {Age} , Grade= {Grade}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Student other) return Id == other.Id;
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}