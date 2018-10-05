# NSwag
Auto Generate Code for C#, Typescript Client.

# Consume Example
```
using System;
using System.Threading.Tasks;
using MyClient;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new StudentClient("http://localhost:5000");
        var student = await client.AddAsync(new Student { Name = "A", Gpa = 4.0f });
        Console.WriteLine(student.Id);

        var client2 = new ValuesClient("http://localhost:5000");

        var list = await client2.GetAllAsync();
        foreach(var value in list)
        {
            Console.WriteLine(value);
        }
    }
}
```