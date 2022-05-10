using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using StudentApp.classes;
using System.Windows.Forms;

namespace StudentApp.ViewModel
{
    internal class NoteFormViewModel : INotifyPropertyChanged
    {
        #region Attributes
        private string _noter;
        public string Noter { 
            get { return _noter; }
            set
            {
                if (_noter == value) return;
                _noter = value;
                OnPropertyChanged();
            }
        }
        
        private string _noteEntry;
        public string NoteEntry { 
            get { return _noteEntry; }
            set
            {
                if (_noteEntry == value) return;
                _noteEntry = value;
                OnPropertyChanged();
            }
        }

        private DateTime _noteDate;
        public DateTime NoteDate
        {
            get { return _noteDate; }
            set
            {
                if (_noteDate == value) return;
                _noteDate = value;
                OnPropertyChanged();
            }
        }

        public BindingList<Note> Notes { get; set; }

        #endregion Attributes

        public NoteFormViewModel()
        {
            Notes = new BindingList<Note>();
            NoteDate = DateTime.Parse(DateTime.Now.ToString());
        }

        public void AddNote()
        {
            Notes.Add(new Note(Noter,NoteEntry,NoteDate));
            Noter = "";
            NoteEntry = "";
            NoteDate = DateTime.Today;
        }

        public void RemoveNote(Note note)
        {
            Notes.Remove(note);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
