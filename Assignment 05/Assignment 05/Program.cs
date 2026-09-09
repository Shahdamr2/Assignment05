using Assignment_05.Entities;


namespace Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01

            //Book book = new Book();

            //Console.WriteLine(book.password);
            // Compile-time error because password is private.
            // It can only be accessed inside the Book class.

            #endregion
            #region Question 02

            //Book book = new Book();

            //Console.WriteLine($"Copies in stock: {book.copiesInStock}");
            // It compiles because internal members can be accessed
            // from anywhere within the same project
            #endregion
            #region Question 03

            Book book = new Book();

            book.Title = "Clean Code";

            Console.WriteLine($"Title: {book.Title}");

            #endregion
        }
    }
}
