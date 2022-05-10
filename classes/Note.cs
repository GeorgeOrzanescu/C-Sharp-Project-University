using System;

namespace StudentApp.classes
{
    public class Note
    {
        public string Noter { get; set; }
        public string NoteEntry { get; set; }
        public DateTime NoteDate { get; set; }

        public Note(string noter, string noteEntry, DateTime noteDate)
        {
            Noter = noter;
            NoteEntry = noteEntry;
            NoteDate = noteDate;
        }
    }
}
