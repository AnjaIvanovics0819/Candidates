using System.ComponentModel.DataAnnotations;

namespace User.Models
{
    public class Form
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}