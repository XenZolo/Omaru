using System.ComponentModel.DataAnnotations;

namespace Omaru.Models
{

    public class Users
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        public string  username { get; set; }

        [Required]
        [MaxLength(50)]
        public string password { get; set; }

        [Required]
        [MaxLength(50)]
        public string  role { get; set; }


    }

}