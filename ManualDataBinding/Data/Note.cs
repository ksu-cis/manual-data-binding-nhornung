using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {

        public event EventHandler NoteChanged;

        private string title = DateTime.Now.ToString();
        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                if (title == value) return; // Checks if the title was changed at all
                title = value;
                NoteChanged?.Invoke(this, new EventArgs()); // THIS particular note is changing this instance of note
                // Question mark checks if the change was null
            }
        }

        private string body = "";
        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body
        {
            get { return body; }
            set
            {
                if (body == value) return;
                body = value;
                NoteChanged?.Invoke(this, new EventArgs());
            }
        }
    }
}
