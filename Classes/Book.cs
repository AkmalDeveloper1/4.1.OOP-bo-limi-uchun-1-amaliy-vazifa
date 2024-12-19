namespace OOP_Classes
{
    class Book
    {
        public Book() { }

        public Book(string name, string author, decimal price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        private decimal allPrice;
        public decimal GetPriceOfAll(int count)
        {
            allPrice = count * Price;
            return allPrice;
        }
        public void InformationsAboutOrder(int count)
        {
            Console.WriteLine($"----Your order----\nName: {Name}\nAuthor: {Author}\nCount: {count}\nPrice All: {allPrice} so'm");
        }
    }
}