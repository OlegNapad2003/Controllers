using MVC.Repository;

namespace MVC.Repository
{
    public static class Storage
    {
        public static ClientStorage ClientStorage { get; } = new ClientStorage();
        public static OrderStorage OrderStorage { get; } = new OrderStorage();

    }
}