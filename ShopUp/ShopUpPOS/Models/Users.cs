using System.ComponentModel.DataAnnotations;

namespace ShopUpPOS.Models
{
    public class Users
    {
        [Key]//Called Data Anotation
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Status { get; set; }


    }
}
