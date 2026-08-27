namespace Day6
{
        public class Magazine : IItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int IssueNumber { get; set; }
 
        public Magazine(int Id, string Title, int IssueNumber)
        {
            this.Id = Id;
            this.Title = Title;
            this.IssueNumber = IssueNumber;
        }
        public string GetInfo()
        {
            return $"Magazine: {Title}, Issue No = {IssueNumber}";
        }
        public override string ToString()
        {
            return $"Magazine: Id= {Id}, Title= {Title}, IssueNumber= {IssueNumber}";
        }
        public override bool Equals(object obj)
        {
             if (obj is Magazine other) return Id == other.Id;
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}