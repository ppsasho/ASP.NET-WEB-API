using NotesApp_Tags.Models;
using NotesApp_Tags.Models.Enums;
using System.Drawing;

namespace NotesApp_Tags.Db
{
    public static class StaticDb
    {
        public static List<string> Users { get; set; } = new List<string>()
        {
            "Sasho",
            "Teodor",
            "Maximus",
            "Filip",
            "Leonid",
            "Martin"
        };
        public static List<Note> Notes { get; set; } = new List<Note>()
        {
            new()
            {
                Text = "Go about your day",
                Priority = Priority.Low,
                Tags = { new Tag { Name = "Chill", Color = "Green"  } },
            },
            new()
            {
                Text = "Chores",
                Priority = Priority.Medium,
                Tags = { new Tag { Name = "Do your chores", Color = "Yellow" } }
            }
        };
    }
}
