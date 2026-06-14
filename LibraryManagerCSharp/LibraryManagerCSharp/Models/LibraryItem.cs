namespace LibraryProject.Models
{
    public abstract class LibraryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }

        protected LibraryItem(int id, string title, int year)
        {
            Id = id;
            Title = title;
            Year = year;
        }
    }
}