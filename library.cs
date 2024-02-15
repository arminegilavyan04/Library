namespace Library1;

public class Book
{
    public Book(string title, string author, int year, int id, string category, double price)
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
        this.Id = id;
        this.Category = category;
        this.Price = price;
    }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int Id { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}
public class Author
{
    public Author(string name, string bio)
    {
        this.Name = name;
        this.Bio = bio;
    }
    
    public string Name { get; set; }

    public string Bio { get; set; }
}
public class Category
{
    public Category(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }
    public string Name { get; set; }
    public string Description { get; set; }
}
public static class Library
{
    private static List<Book> books = new List<Book>();

    public static void AddBook(Book book)
    {
        books.Add(book);
    }
    public static void RemoveBook(string title)
    {
        books.RemoveAll(book => book.Title == title);
    }
    public static void ListBook()
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Id: {book.Id}, Year: {book.Year}, Price: {book.Price}, Category: {book.Category}");
        }
    }
}
class library
{
    static void Main(string[] args)
    {
        static void AddBook()
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author Name: ");
            string author = Console.ReadLine();
            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Price: ");
            string name = Console.ReadLine();
            Console.Write("Enter Category Description: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Enter Category Name: ");
            string description = Console.ReadLine();

            Category category = new Category(name, description);
            Book book = new Book(title, author, year, id, name, price);

            Library.AddBook(book);
            Console.WriteLine("Book added to your library.");
        }
        static void RemoveBook()
        {
            Console.Write("Enter Book Title to Remove: ");
            string title = Console.ReadLine();

            Library.RemoveBook(title);
            Console.WriteLine("Book removed from your library.");
        }

        static void ListAllBooks()
        {
            Library.ListBook();
        }
    }
}