using LibraryProject.Models;
using LibraryProject.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace LibraryProject.Services
{
    public class LibraryService
    {
        public List<LibraryItem> GetAll()
        {
            return repo.GetAll();
        }

        private readonly LibraryRepository repo;
        private int nextId = 1;

        public LibraryService(LibraryRepository repo)
        {
            this.repo = repo;
        }

        public void AddBook(string title, int year, string author)
        {
            repo.Add(new Book(nextId++, title, year, author));
        }

        public void AddMagazine(string title, int year, int issue)
        {
            repo.Add(new Magazine(nextId++, title, year, issue));
        }

        public void Delete(int id)
        {
            repo.Remove(id);
        }

        public void PrintAll()
        {
            foreach (var item in repo.GetAll())
            {
                if (item is Book b)
                {
                    System.Console.WriteLine($"[Книга] {b.Id} {b.Title} {b.Year} {b.Author}");
                }
                else if (item is Magazine m)
                {
                    System.Console.WriteLine($"[Журнал] {m.Id} {m.Title} {m.Year} {m.IssueNumber}");
                }
            }
        }

        public void PrintStats()
        {
            var items = repo.GetAll();

            int books = items.Count(x => x is Book);
            int magazines = items.Count(x => x is Magazine);

            System.Console.WriteLine($"Книги: {books}");
            System.Console.WriteLine($"Журналы: {magazines}");
            System.Console.WriteLine($"Итого: {items.Count}");
        }

        public void Update(int id, string title, int year, string extra)
        {
            var item = repo.GetById(id);

            if (item == null)
                return;

            item.Title = title;
            item.Year = year;

            if (item is Book book)
            {
                book.Author = extra;
            }
            else if (item is Magazine magazine)
            {
                magazine.IssueNumber = int.Parse(extra);
            }
        }


    }
}