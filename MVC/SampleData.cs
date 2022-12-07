using MVC.Models;
using System.Linq;
using System.Numerics;


namespace Filling
{
    public static class SampleData
    {
        public static void Initialize(Context context)
        {
            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client
                    {
                        FIO = "Petrov Petr Petrovich",
                        Stage = 20,
                        Index = 1234
                    },
                    new Client
                    {
                        FIO = "Ivanov Ivan Ivanovich",
                        Stage = 3,
                        Index = 2341
                    },
                    new Client
                    {
                        FIO = "Kuzmin Antob Igorevich",
                        Stage = 2,
                        Index = 3412
                    }
                );
                context.SaveChanges();
            }
        }
    }
}