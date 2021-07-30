using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UserAddressMicroservice
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new UserAddressDbContext();

            Console.WriteLine("Hello World!");



        }
    }
}
