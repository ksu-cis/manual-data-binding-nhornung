using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Create the note to add to our editor
        /// </summary>
        Note note = new Note();

        public MainWindow()
        {
            InitializeComponent();

            // Must do this after initialize component, editor is name in xaml
            Editor.Note = note;
        }

        /// <summary>
        /// Event listener to handle new note on button click and apply to editor
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="e">event arguments</param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note; // Keep the editor and cs in sync

            //Editor.OnNoteChanged(note.Title, note.Body);
        }

        /// <summary>
        /// Event handler to clear the contents of the note
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="e">event arguments</param>
        public void OnClearNote(object sender, RoutedEventArgs e)
        {
            note.Body = "";
        }

        /// <summary>
        /// event handler to mutate the current note
        /// </summary>
        /// <param name="sender">button clicked</param>
        /// <param name="e">event arguments</param>
        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "Master Splitter";
            note.Body = "There is no monster more dangerous than a lack of composition";
        }
    }
}
