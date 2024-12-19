using OOP_Classes;
class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int count = random.Next(1,10);

        Book book1 = new Book(name: "Ikki shaharning hikoyasi", author: "Charles Dickens", price: 30000);
        Book book2 = new Book
        {
            Name = "Kichkina shahzoda",
            Author = "Antoine de Saint-Exupéry",
            Price = 50000
        };

        decimal price = book1.GetPriceOfAll(count);
        Console.WriteLine("Hammasini narxi: {0} so'm", price);
        book1.InformationsAboutOrder(count);

        price = book2.GetPriceOfAll(count);
        Console.WriteLine("Hammasini narxi: {0} so'm", price);
        book2.InformationsAboutOrder(count);


        Console.ReadLine();
    }
}