using NotesApp_Tags.Models.Enums;

namespace NotesApp_Tags.Models
{
    public class Note
    {
        public string Text { get; set; }
        public Priority Priority { get; set; }
        public List<Tag> Tags { get; set; }

    }
}
