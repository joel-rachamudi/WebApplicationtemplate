using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationtemplate.Models
{
    public class UserProduct
    {
      
        [Key]
        public int Id { get; set; }
        public string? property1 { get; set; }
        public string? property2 { get; set; }
        public string? property3 { get; set; }
        public string? property4 { get; set; }
        
        
    }
}
