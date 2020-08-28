using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    // this model handles the task of collecting property data for a list of notes. When a user enters information, we will want them to enter specific data. When we show information, we will want to show specific data in specific views.

    // MAKE PUBLIC
    public class NoteListItem
    {
        // PROPERTIES
        public int NoteId { get; set; }
        public string Title { get; set; }

        [Display(Name = "Created")] // change the display name to Created
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
