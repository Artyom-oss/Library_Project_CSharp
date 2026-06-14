namespace LibraryProject.Models
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public Magazine(int id, string title, int year, int issue)
            : base(id, title, year)
        {
            IssueNumber = issue;
        }

        public override string ToString()
        {
            return $"ID: {Id} | Журнал | Название: {Title} | Год: {Year} | Выпуск: {IssueNumber}";
        }
    }
}