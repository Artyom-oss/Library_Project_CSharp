namespace LibraryProject.Models
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }

        public Book(int id, string title, int year, string author)
            : base(id, title, year)
        {
            Author = author;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Книга | Название: {Title} | Год: {Year} | Автор: {Author}";
        }
    }
}