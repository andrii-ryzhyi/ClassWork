namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new string[]
            {
                @"Text for first page
                lkjnhkjhukk
                kjkjhkhkkj",

                 @"Text for second page
                 lkjnljnbjknlj
                 ;lk,k;lujkbkh",

                @"Text for third page
                 lkjnljnbjknlj
                 ;lk,k;lujkbkh" 
            };
            Book book = new Book("Name", "Author", 100, text);
            string author = book.Author;
            string title = book.Title;
            string page = book.StartReading();
            Console.WriteLine($"Title: {title}, author: {author}\n Start reading the book...\n {page}");

            Console.WriteLine("Next page");
            page = book.NextPage();
            Console.WriteLine(page);

            Console.WriteLine("Next page");
            page = book.NextPage();
            Console.WriteLine(page);

            Console.WriteLine("Next page");
            page = book.NextPage();
            Console.WriteLine(page);

            page = book.PreviousPage();
            Console.WriteLine(page);

            Console.WriteLine("Get all pages");
            string textOfBook = book.GetAllPages();
            Console.WriteLine(textOfBook);
        }
    }
}