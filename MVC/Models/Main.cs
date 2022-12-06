using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Main
    {
        [Key]
        public int Id { get; set; }
        public string FIO { get; set; }
        public int Stage { get; set; }
        public int Index { get; set; }
    }
}
