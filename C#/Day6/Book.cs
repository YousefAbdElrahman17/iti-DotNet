namespace Day6
{
    public class Book : IItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
 
        public Book(int Id, string Title, string Author, float Price)
        {
            this.Id = Id;
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }
        public string GetInfo()
        {
            return $"Book: {Title} by {Author} , Price = {Price}";
        }
        public override string ToString()
        {
            return $"Book: Id= {Id}, Title= {Title}, Author= {Author}, Price= {Price}";
        }
        public override bool Equals(object obj)
        {    
            if (obj is Book other) return Id == other.Id;
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
 