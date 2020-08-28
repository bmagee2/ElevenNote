using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    // MAKE PUBLIC
    public class Note
    {
        // PROPERTIES
        [Key]   // uniquely identifies an entity; primary key of the corresponding database; NoteId will always be a unique number
        public int NoteId { get; set; }

        [Required]
        public Guid OwnerId { get; set; } // Guid -- Globally Unique IDentifier -- type that allows us to create unique, near impossible to replicate (like 1 in 1 trillion chance) IDs

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
