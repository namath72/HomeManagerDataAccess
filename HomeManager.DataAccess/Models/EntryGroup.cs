using System.ComponentModel.DataAnnotations;

namespace HomeManager.DataAccess.Models
{
    public class EntryGroup
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Description { get; set; }
    }
}
