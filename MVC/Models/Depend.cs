using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Depend
    {
        [Key]
    public int OrderId { get; set; } 
    public string Type { get; set; } 
     public int Price { get; set; }
     public  string Name { get; set; }
        
     public int MainId { get; set; } 
        public Main Main { get; set; }  
            
    }
}
