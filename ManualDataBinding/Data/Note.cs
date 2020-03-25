using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title { get; set; } = DateTime.Now.ToString();

        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body { get; set; } = "";
    }
}
