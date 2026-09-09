using Assignment_05.Entities;


namespace Assignment_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01

            Book book = new Book();

            Console.WriteLine(book.password);
            // Compile-time error because password is private.
            // It can only be accessed inside the Book class.

            #endregion
        }
    }
}
