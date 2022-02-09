using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeManager.DataAccess.Models
{
    public class Entry
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public EntryGroup group { get; set; }

    }
}
