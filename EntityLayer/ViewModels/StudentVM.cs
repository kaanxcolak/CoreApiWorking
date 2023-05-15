using System.ComponentModel.DataAnnotations;

namespace EntityLayer.ViewModels
{
    public class StudentVM
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
               
        public string? FirstName { get; set; }

        public string? SecondName { get; set; }

        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }
    }
}
