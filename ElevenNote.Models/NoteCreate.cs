using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    // model that allow us to have some validation for the note properties
    // need to create a Title, Content, and DateCreated
    // The id will be created after the POST request happens, after we fill out a form with the two properties above. So, we won't provide that. Our .Service and .Data layer will work together to take care of that

    // MAKE PUBLIC
    public class NoteCreate
    {
        // PROPERTIES
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "There are too many characters in this field.")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Content { get; set; }
    }
}
