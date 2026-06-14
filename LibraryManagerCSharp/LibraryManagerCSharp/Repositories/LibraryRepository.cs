using LibraryProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace LibraryProject.Repositories
{
    public class LibraryRepository
    {
        // Хранилище всех объектов (книги + журналы)
        private List<LibraryItem> items = new List<LibraryItem>();

        // Добавление элемента в библиотеку
        public void Add(LibraryItem item)
        {
            items.Add(item);
        }

        // Удаление по ID
        public void Remove(int id)
        {
            var item = items.FirstOrDefault(x => x.Id == id);

            if (item != null)
            {
                items.Remove(item);
            }
        }

        // Получить все элементы
        public List<LibraryItem> GetAll()
        {
            return items;
        }

        // Найти по ID
        public LibraryItem GetById(int id)
        {
            return items.FirstOrDefault(x => x.Id == id);
        }
    }
}