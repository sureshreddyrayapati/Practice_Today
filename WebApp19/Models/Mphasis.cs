using System.ComponentModel.DataAnnotations;

namespace WebApp19.Models
{
    public class Mphasis
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public string Loction { get; set; }
        public DateTime joinDate { get; set; }
    }
}
//DESKTOP-B13B310\SQLEXPRESS
//Data Source=DESKTOP-B13B310\SQLEXPRESS;Initial Catalog=Company;Integrated Security=True;Trust Server Certificate=True