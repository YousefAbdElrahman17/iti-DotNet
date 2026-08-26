using System.Reflection;

using System;
struct Customer
{
    int   customerId;
    string customerName;
    int   customerAge;

    public int CustomerId
    {
        get{return customerId;}
        set{customerId=value;}
    }
    public string CustomerName
    {
        get{return customerName;}
        set{customerName=value;}
    }
    public int CustomerAge
    {
        get{return customerAge;}
        set{customerAge=value;}
    }
}


internal class Program
{
    static void Main(string[] args)
    {
        // ---------------------------- (1) Declare Movies ----------------------------
        string[] cinemaMovies = new string[]{"Interstellar", "InceptionThe", "Dark Knight", "Avatar", "The Matrix"};
        
        // ---------------------------- (2) Seats Stautes ----------------------------
        char[,] cinemaSeats = new char[5,8];
        for(int i=0; i<5; i++)
        {
            for(int j=0; j<8; j++)
            {
                cinemaSeats[i,j] = 'o'; 
            }
        }

        // ---------------------------- (3) Jagged Halls ----------------------------
        char[][] cinemaHalls = new char[3][];
        cinemaHalls[0] = new char[10];        
        cinemaHalls[1] = new char[15];
        cinemaHalls[2] = new char[20];
        for(int i=0; i<cinemaHalls.Length; i++)
        {
            for(int j=0; j<cinemaHalls[i].Length; j++)
            {
                cinemaHalls[i][j] = 'o'; 
            }
        }

        // ---------------------------- (4) Adding 3 Customers ----------------------------
        Customer[] customer = new Customer[3];
        customer[0].CustomerId = 301; customer[0].CustomerName = "Ali"; customer[0].CustomerAge = 61;
        customer[1].CustomerId = 302; customer[1].CustomerName = "Noor"; customer[1].CustomerAge = 18;
        customer[2].CustomerId = 303; customer[2].CustomerName = "Zain"; customer[2].CustomerAge = 10;  

        bool running = true;

        while (running)
        {
            Console.WriteLine("----------------> Cinema System <----------------");
            Console.WriteLine("1. Display Movies\n2. Display Seats\n3. Reserve Seat\n4. Display Available Seats\n5. Display Customers\n6. Search Customer\n7. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    DisplayMovies(cinemaMovies);
                    break;
                case 2:
                    DisplaySeats(cinemaSeats);
                    break;
                case 3:
                    ReserveSeats(cinemaHalls, customer);
                    break;
                case 4:
                    DisplayAvailableSeats(cinemaHalls);
                    break;
                case 5:
                    DisplayCustomers(customer);
                    break;
                case 6:
                    SearchCustomer(customer);
                    break;
                case 7:
                    running = false;
                    Console.WriteLine("Thanks for choosing us <3");
                    break;  
                default:
                Console.WriteLine("Invalid option! choose again"); 
                break;
            }
        }
    }

    static void DisplayMovies(string[] movies)
    {
        Console.WriteLine("------------- Movies -------------");
        for(int i=0; i<movies.Length; i++)
        {
            Console.WriteLine($"Movie({i+1}): {movies[i]}");
        }
    }
    static void DisplaySeats(char[,] seats)
    {
        Console.WriteLine("------------- Cinema Seats -------------");
        for(int col=0; col<8; col++) Console.Write($"{col+1} ");
        Console.WriteLine();
        for(int row=0; row<5; row++)
        {
            Console.Write($"({row+1}) ");
            for(int col=0; col<8; col++){
            Console.Write($"{seats[row,col]} ");
            }
            Console.WriteLine();   
        }
    }    
    static void ReserveSeats(char[][] halls, Customer[] customer)
    {
        Console.Write($"Enter Hall Number  (1- {halls.Length}): ");
        int hallNumber = int.Parse(Console.ReadLine());

        int hallIndex = hallNumber-1;
        Console.Write($"Enter Seat Number  (1- {halls[hallIndex].Length}): ");
        int seatNumber = int.Parse(Console.ReadLine());

        int seatIndex = seatNumber-1;
        if(halls[hallIndex][seatIndex] == 'x')
            Console.WriteLine("Sorry this Seat is already reserved");
        
        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Customer Age: ");
        int age = int.Parse(Console.ReadLine());
        
        halls[hallIndex][seatIndex] = 'x';
        Console.WriteLine("Seat reserved Successfuly!");

        int price;
        if(age<12) price = 5;
        else if(age<=59) price = 10;
        else price = 10;

        Console.WriteLine("----------- Ticket Booked Successfuly! -----------");
        Console.WriteLine($"Hall: {hallNumber}");
        Console.WriteLine($"Seat: {seatNumber}");
        Console.WriteLine($"Customer: {name}");
        Console.WriteLine($"Ticket Price: {price}");
            
    }
    static void DisplayAvailableSeats(char[][] halls)
    {
        Console.WriteLine("-------------- Available Seats Per Hall --------------");
        for(int i=0; i<halls.Length; i++)
            {
                int available = 0;
                for(int j=0; j<halls[i].Length; j++)
                {
                    if (halls[i][j] == 'o') available++;
                }
                Console.WriteLine($"Hall({i+1}) -> {available} available seats");
            }
    }
    static void DisplayCustomers(Customer[] customer)
    {
        Console.WriteLine("------------- Customer -------------");
        for(int i=0; i<customer.Length; i++)
        {
            Console.WriteLine($"Customer ID: {customer[i].CustomerId}");
            Console.WriteLine($"Customer Name: {customer[i].CustomerName}");
            Console.WriteLine($"Customer Age: {customer[i].CustomerAge}");
        }
    }
    static void SearchCustomer(Customer[] customer)
    {
        Console.Write("Enter Customer ID: ");
        int inID = int.Parse(Console.ReadLine());
        bool found = false;
        for(int i=0; i<customer.Length; i++)
            {
                if(customer[i].CustomerId == inID)
                {
                    Console.WriteLine("----------- Customer Found! -----------");
                    Console.WriteLine($"Customer ID: {customer[i].CustomerId}");
                    Console.WriteLine($"Customer Name: {customer[i].CustomerName}");
                    Console.WriteLine($"Customer Age: {customer[i].CustomerAge}");
                    found = true;
                    break;
                }  
            }    
        if(!found) Console.WriteLine("Customer not found!");
    }
}