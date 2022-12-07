using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Order
    {
        [Key]
    public int Id { get; set; } 
    public string Type { get; set; } 
    public int Price { get; set; }
    public  string Name { get; set; }
        
    public int ClientId { get; set; } 
    public  Client Client { get; set; }  
            
    }
}
