namespace InstantPlans
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for TaskWindowControl.
    /// </summary>
    public partial class TaskWindowControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWindowControl"/> class.
        /// </summary>
        public TaskWindowControl()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void AddTaskClick(object sender, RoutedEventArgs e)
        {
            //TextBox addtask = AddTaskTextBox;
            this.TaskListBox.Items.Add(this.AddTaskTextBox.Text);
            MessageBox.Show("Task added");
        }

        private void AddTaskTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TaskListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*TextBox addtask = AddTaskTextBox;
            this.TaskListBox.Items.Add(this.AddTaskTextBox.Text);*/
        }
    }
}