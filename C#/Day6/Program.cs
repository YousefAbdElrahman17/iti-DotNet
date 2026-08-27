namespace Day6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shapes();
            Generics();
            Collections();
            Library();
        }
        private static void Shapes()    //task1
        {
            Console.WriteLine("-------- Interfaces --------");
 
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new Circle(5));
            shapes.Add(new Rectangle(4, 6));
            shapes.Add(new Triangle(3, 8));
            shapes.Add(new Square(4));
 
            foreach (IShape shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
            Console.WriteLine("\n=======================\n\n");
        }
        private static void Generics()      //task2
        {
            Console.WriteLine("\n--------- Generics ------");
 
            Repository<Student> studentRepo = new Repository<Student>();
            studentRepo.Add(new Student(1, "Ali", "ali@mail.com", 20, 88.5f));
            studentRepo.Add(new Student(2, "Sara", "sara@mail.com", 22, 91.0f));
            studentRepo.Add(new Student(3, "Omar", "omar@mail.com", 21, 75.0f));
 
            Console.WriteLine("\n--------- All students ---------");
            foreach (Student s in studentRepo.GetAll())
            {
                Console.WriteLine(s.ToString());
            }
 
            Student found = studentRepo.Find(new Student(2, "", "", 0, 0));
            Console.WriteLine($"Found by Id 2: {found}");
 
            Student foundByPredicate = null;
            foreach (Student s in studentRepo.GetAll())
            {
                if(s.Grade > 90)
                {    
                    foundByPredicate = s;
                    break;    
                }
            }
            Console.WriteLine($"Found with Grade > 90: {foundByPredicate}");
 
             Console.WriteLine("\n=======================");

            studentRepo.Remove(new Student(3, "", "", 0, 0));
            Console.WriteLine("------- After removing student Id 3 -------");
            foreach (Student s in studentRepo.GetAll())
            {
                Console.WriteLine(s.ToString());
            }
 
            Repository<Book> bookRepo = new Repository<Book>();
            bookRepo.Add(new Book(1, "Clean Code", "Robert C. Martin", 35.0f));
            bookRepo.Add(new Book(2, "C# in Depth", "Jon Skeet", 40.0f));
 
            Console.WriteLine("\n--------- All books ------------");
            foreach (Book b in bookRepo.GetAll())
            {
                Console.WriteLine(b.ToString());
            }
 
            bookRepo.Clear();
            Console.WriteLine($"Books repository cleared. Count = {bookRepo.Count()}");
            
            Printer.PrintData<int>(10);
            Printer.PrintData<string>("Hello");
            Printer.PrintData<float>(3.14f);
 
            Console.WriteLine("\n================================\n\n");
        }
 
        private static void Collections()       //task3
        {
            Console.WriteLine("----------- Collections ---------\n");

            List<Student> studentList = new List<Student>();
            studentList.Add(new Student(1, "Ali", "ali@mail.com", 20, 88.5f));
            studentList.Add(new Student(2, "Sara", "sara@mail.com", 22, 91.0f));
            studentList.Add(new Student(3, "Omar", "omar@mail.com", 21, 75.0f));
            studentList.Add(new Student(4, "Mona", "mona@mail.com", 23, 80.0f));
            studentList.Add(new Student(5, "Karim", "karim@mail.com", 19, 70.0f));
 
            Console.WriteLine("----- List<Student>: search Id 3 ------");
            Student searched = null;
            foreach (Student s in studentList)
            {
                if (s.Id == 3)
                {
                    searched = s;
                    break;
                }
            }
            Console.WriteLine($"Search result: {searched}\n");
 
            Console.WriteLine("--------- List<Student>: remove Id 4 ------");
            Student toRemove = null;
            foreach (Student s in studentList)
            {
                if (s.Id == 4)
                {
                    toRemove = s;
                    break;
                }
            }
            if (toRemove != null) studentList.Remove(toRemove); // we can replace all this by remove but this for null.
 
            Console.WriteLine("\n-------- List<Student>: display all --------");
            foreach (Student s in studentList)
            {
                Console.WriteLine(s.ToString());
            }
 
            Console.WriteLine("-- Dictionary<int, Student> --");
            Dictionary<int, Student> studentDict = new Dictionary<int, Student>();
            foreach (Student s in studentList)
            {
                if (!studentDict.ContainsKey(s.Id)) studentDict.Add(s.Id, s);
                else Console.WriteLine($"\nDuplicate Id {s.Id} ignored \n");
            }
 
            Student duplicateIdStudent = new Student(1, "Fake Ali", "fake@mail.com", 30, 60.0f);
            if (!studentDict.ContainsKey(duplicateIdStudent.Id))studentDict.Add(duplicateIdStudent.Id, duplicateIdStudent);
            else Console.WriteLine($"Duplicate Id {duplicateIdStudent.Id} ignored (already exists)\n");

            Console.WriteLine($"Search Id 2 in dictionary: {studentDict[2]}");
 
            studentDict.Remove(5);
            Console.WriteLine("\n--------- Dictionary after removing Id 5 ----------");
            foreach (KeyValuePair<int, Student> pair in studentDict) Console.WriteLine($"Key= {pair.Key} : {pair.Value}");
 
            Console.WriteLine("\n----------- HashSet<string> of emails ----------");
            HashSet<string> emails = new HashSet<string>();
            foreach (Student s in studentList)
            {
                bool added = emails.Add(s.Email);
                if (!added) Console.WriteLine($"Duplicate email skipped: {s.Email}");
            }
 
            bool addedDuplicate = emails.Add("ali@mail.com");
            Console.WriteLine($"\nTrying to add duplicate email 'ali@mail.com': added = {addedDuplicate}");
 
            Console.WriteLine($"Contains 'sara@mail.com'? {emails.Contains("sara@mail.com")}");
 
            emails.Remove("sara@mail.com");
            Console.WriteLine("\n-------- Emails after removing sara@mail.com --------");
            foreach (string email in emails)Console.WriteLine(email);
            Console.WriteLine("=============================================\n");
        }
 
        private static void Library()      //bonus task
        {
            Console.WriteLine("-------------- Library --------------");
 
            List<int> numbers = new List<int> { 4, 9, 1, 7, 3 };
            Console.WriteLine($"Max = {CollectionHelper.FindMax(numbers)}");
            Console.WriteLine($"Min = {CollectionHelper.FindMin(numbers)}");
 
            Console.WriteLine("\n--------- Library System ----------");
            Repository<IItem> libraryRepo = new Repository<IItem>();
            libraryRepo.Add(new Book(1, "Clean Code", "Robert C. Martin", 35.0f));
            libraryRepo.Add(new Magazine(2, "National Geographic", 245));
 
            foreach (IItem item in libraryRepo.GetAll()) Console.WriteLine(item.GetInfo());
           
            Dictionary<int, IItem> libraryDict = new Dictionary<int, IItem>();
            foreach (IItem item in libraryRepo.GetAll()) libraryDict[item.Id] = item;
            
            Console.WriteLine($"Library item Id 2: {libraryDict[2].GetInfo()}");
 
            HashSet<string> libraryTitles = new HashSet<string>();
            foreach (IItem item in libraryRepo.GetAll()) libraryTitles.Add(item.Title);
            Console.WriteLine("\n-------- Unique titles in library ------");
            foreach (string title in libraryTitles) Console.WriteLine(title);
        }
    }
}