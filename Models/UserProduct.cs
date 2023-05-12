using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eshop.Models
{     public class UserProduct
      {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? property1 { get; set; }
        public string? property2 { get; set; }
        public string? property3 { get; set; }
        public string? property4 { get; set; }

        }
}
