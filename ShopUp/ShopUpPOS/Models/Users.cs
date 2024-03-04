using System.ComponentModel.DataAnnotations;

namespace ShopUpPOS.Models
{
    public class Users
    {
        [Key]//Called Data Anotation
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [MaxLength(60)]
      
        public string Name { get; set; }
        [Required(ErrorMessage = "Status is Required")]
        [MaxLength(50)]

        public string Status { get; set; }


    }
}
