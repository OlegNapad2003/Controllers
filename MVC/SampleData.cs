using MVC.Models;
using System.Linq;
using System.Numerics;


namespace MobileStore
{
    public static class SampleData
    {
        public static void Initialize(Context context)
        {
            if (!context.Mains.Any())
            {
                context.Mains.AddRange(
                    new Main
                    {
                        FIO = "Petrov Petr Petrovich",
                        Stage = 20,
                        Index = 1234
                    },
                    new Main
                    {
                        FIO = "Ivanov Ivan Ivanovich",
                        Stage = 3,
                        Index = 2341
                    },
                    new Main
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