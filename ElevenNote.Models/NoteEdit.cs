using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    // MAKE PUBLIC
    public class NoteEdit
    {
        // PROPERTIES
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
