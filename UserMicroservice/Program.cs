using System;

namespace UserMicroservice
{
    public class Program
    {
        static void Main(string[] args)
        {
            var c = new UserDbContext();
            c.Database.EnsureDeleted();
            c.Database.EnsureCreated();

            Console.WriteLine("Hello World!");
            
        }
    }
}
