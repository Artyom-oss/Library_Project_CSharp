using LibraryProject.Models;
using LibraryProject.Repositories;
using LibraryProject.Services;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var repo = new LibraryRepository();
        var service = new LibraryService(repo);
        List<LibraryItem> library = new List<LibraryItem>();

        while (true)
        {
            Console.WriteLine("\n1. Добавить книгу");
            Console.WriteLine("2. Добавить журнал");
            Console.WriteLine("3. Посмотреть хранилище");
            Console.WriteLine("4. Удалить");
            Console.WriteLine("5. Статистика");
            Console.WriteLine("6. Редактировать");
            Console.WriteLine("0. Выход");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Название: ");
                    string bt = Console.ReadLine();
                    Console.Write("Год: ");
                    int by = int.Parse(Console.ReadLine());
                    Console.Write("Автор: ");
                    string ba = Console.ReadLine();

                    service.AddBook(bt, by, ba);
                    break;

                case 2:
                    Console.Write("Название: ");
                    string mt = Console.ReadLine();
                    Console.Write("год: ");
                    int my = int.Parse(Console.ReadLine());
                    Console.Write("выпуск: ");
                    int mi = int.Parse(Console.ReadLine());

                    service.AddMagazine(mt, my, mi);
                    break;

                case 3:
                    Console.WriteLine("\n===== СПИСОК =====");

                    var items = service.GetAll();
                    foreach (var item in items)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;

                case 4:
                    Console.Write("ID: ");
                    int id = int.Parse(Console.ReadLine());
                    service.Delete(id);
                    break;

                case 5:
                    service.PrintStats();
                    break;

                case 6:

                    Console.Write("ID: ");
                    int editId = int.Parse(Console.ReadLine());

                    Console.Write("Новое название: ");
                    string newTitle = Console.ReadLine();

                    Console.Write("Новый год: ");
                    int newYear = int.Parse(Console.ReadLine());

                    Console.Write("Новый автор/выпуск: ");
                    string extra = Console.ReadLine();

                    service.Update(editId, newTitle, newYear, extra);

                    Console.WriteLine("Запись обновлена.");

                    break;
                case 0:
                    return;
            }
        }
    }
}