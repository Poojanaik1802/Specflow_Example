namespace Specflow_Example
{
    public class BookService
    {
        private readonly List<Book> _bookList= new List<Book>();
        public void AddBook(Book book)
        {
            _bookList.Add(book);
        }

        public Book GetBook(string bookName)
        {
            return _bookList.Single(x=>x.Name == bookName);
        }
    }
}
