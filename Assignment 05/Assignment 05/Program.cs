using Assignment_05.Entities;
using Assignment_05.Entities.Enums;


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

            //Book book = new Book();

            //book.Title = "Clean Code";

            //Console.WriteLine($"Title: {book.Title}");

            #endregion
            #region Question 04

            //Book book = new Book();

            //book.Genre = Genre.Science;

            //Console.WriteLine($"Genre: {book.Genre}");

            #endregion
            #region Question 05

            //Console.WriteLine($"Fiction: {(int)Genre.Fiction}");
            //Console.WriteLine($"NonFiction: {(int)Genre.NonFiction}");
            //Console.WriteLine($"Science: {(int)Genre.Science}");

            #endregion
            #region Question 06

            int genreNumber = 1;

            Genre genre = (Genre)genreNumber;

            Console.WriteLine($"Genre: {genre}");

            #endregion
        }
    }
}
