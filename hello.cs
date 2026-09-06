using System;
using Bogus;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine($"Сегодня: {DateTime.Now:d}");
        
        // TODO: Добавить проверку на пустой ввод
        
        var faker = new Faker("ru");
        Console.WriteLine($"Имя: {faker.Name.FullName()}");
        Console.WriteLine($"Адрес: {faker.Address.FullAddress()}");
    }
}