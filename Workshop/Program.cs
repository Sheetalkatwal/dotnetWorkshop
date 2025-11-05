//namespace workshop
{
    //class Program
    //{
    //    // TASK 1
    //    static void Main(string[] args)
    //    {
    //        // Declare variable to store name
    //        string userName = "Sital";

    //        // Declare variable to store lucky number
    //        int luckyNumber = 10;

    //        // Print using string interpolation
    //        Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
    //    }
    //}

    // TASK 2
    //class Circle
    //{
    //    public const double PI = 3.14;

    //    public static double CalculateArea(double radius)
    //    {
    //        return PI * radius * radius;
    //    }

    //    public static double CalculatePerimeter(double radius)
    //    {
    //        return 2 * PI * radius;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double radius = 5;

    //        double area = Circle.CalculateArea(radius);
    //        double perimeter = Circle.CalculatePerimeter(radius);

    //        Console.WriteLine($"For a circle with radius {radius}:");
    //        Console.WriteLine($"Area = {area}");
    //        Console.WriteLine($"Perimeter = {perimeter}");
    //    }
    //}


    //TASK 3
    //class Program
    //{
    //    static void Main()
    //    {
    //        byte age = 25;                     
    //        short year = 2025;                 
    //        int population = 150000;           
    //        long distance = 9812324321;       
    //        float temperature = 36.7f;         
    //        double price = 49.99;              
    //        decimal salary = 85000.75m;        
    //        char grade = 'A';                  
    //        bool isPassed = true;              

    //        int number = 42;
    //        string numberAsString = number.ToString();   // int to string

    //        string valueString = "3.14";
    //        double valueDouble = Convert.ToDouble(valueString); // string to double

    //        Console.WriteLine("byte (age): " + age);
    //        Console.WriteLine("short (year): " + year);
    //        Console.WriteLine("int (population): " + population);
    //        Console.WriteLine("long (distance): " + distance);
    //        Console.WriteLine("float (temperature): " + temperature);
    //        Console.WriteLine("double (price): " + price);
    //        Console.WriteLine("decimal (salary): " + salary);
    //        Console.WriteLine("char (grade): " + grade);
    //        Console.WriteLine("bool (isPassed): " + isPassed);
    //        Console.WriteLine("Converted int to string: " + numberAsString);
    //        Console.WriteLine("Converted string to double: " + valueDouble);
    //    }
    //}


    //TASK 4

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] favoriteNumbers = { 8, 21, 6, 25, 9 };

    //        Array.Sort(favoriteNumbers);

    //        Array.Reverse(favoriteNumbers);

    //        Console.WriteLine("Numbers in descending order:");
    //        for (int i = 0; i < favoriteNumbers.Length; i++)
    //        {
    //            Console.WriteLine(favoriteNumbers[i]);
    //        }

    //        int position = Array.IndexOf(favoriteNumbers, 25);
    //        if (position != -1)
    //        {
    //            Console.WriteLine($"The number 25 is at position {position} in the array.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("The number 25 is not in the array.");
    //        }
    //    }
    //}

    //TASK 5

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DateTime birthDate = new DateTime(2005, 4, 29);

    //        DateTime currentDate = DateTime.Now;

    //        TimeSpan ageSpan = currentDate - birthDate;
    //        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

    //        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
    //        Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
    //        Console.WriteLine($"Age: {ageInYears} years");

    //        DateTime newDate = birthDate.AddDays(10);
    //        Console.WriteLine($"Birthdate + 10 days: {newDate.ToShortDateString()}");
    //    }
    //}

    //TASK 6

    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        List<string> fruits = new List<string> { "Apple", "Orange", "Grapes" };


    //        fruits.Add("Mango");


    //        fruits.Remove("Orange");

    //        Console.WriteLine("Fruits in the list:");
    //        foreach (string fruit in fruits)
    //        {
    //            Console.WriteLine(fruit);
    //        }

    //        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
    //        {
    //            {1, "Apple"},
    //            {2, "Orange"},
    //            {3, "Grapes"}
    //        };


    //        fruitDictionary.Add(4, "Mango");

    //        Console.WriteLine("\nFruits in the dictionary:");
    //        foreach (KeyValuePair<int, string> entry in fruitDictionary)
    //        {
    //            Console.WriteLine($"ID: {entry.Key}, Name: {entry.Value}");
    //        }
    //    }
    //}





}

