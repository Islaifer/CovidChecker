using System.ComponentModel.DataAnnotations;

namespace CovidChecker.Models.Entities{
    public class User{
        [Key]
        public long Id {get; set;}

        [Required]
        public string? Name {get; set;}

        [Required]
        public string? Password {get; set;}
    }
}