using System;
using Bogus;

class Program
{
    static void Main()
    {
        var x = new Faker("ru");
        
        Console.WriteLine($"Имя: {x.Name.FullName()}");
        Console.WriteLine($"Адрес: {x.Address.FullAddress()}");
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"Сегодня: {DateTime.Now:d}");
        
        // TODO: Добавить проверку на пустой ввод
    }
}