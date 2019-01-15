namespace InstantPlans
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Controls;
    using System.Windows;

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

            if (this.AddTaskTextBox.Text == "Input your todo's here...")
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to add placeholder task?", "Warning", MessageBoxButton.YesNo);

                switch(result)
                {
                    case MessageBoxResult.Yes:
                        this.TaskListBox.Items.Add(this.AddTaskTextBox.Text);
                        break;

                    case MessageBoxResult.No:
                        break;
                }

                return;
            }
            this.TaskListBox.Items.Add(this.AddTaskTextBox.Text);
        }

        private void AddTaskTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TaskListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ToDoLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void DoingBox_DragOver(object sender, DragEventArgs e)
        {
        }


        private void TaskListBox_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {

        }


        
        private void DoingBox_Drop(object sender, DragEventArgs e)
        {
         
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                string dataString = (string)e.Data.GetData(DataFormats.StringFormat);
                DoingBox.Items.Add(dataString);
            }
        }

        private void DoingBox_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void TaskListBox_Drop(object sender, DragEventArgs e)
        {
                TaskListBox.Items.Add(e.Data.GetData(DataFormats.StringFormat));

        }

        private void DoingBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DoingBox_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            if (TaskListBox.SelectedIndex != -1)
            {
                DoingBox.Items.Add(TaskListBox.SelectedItem);
            }
            if (DoneBox.SelectedIndex != -1)
            {
                DoingBox.Items.Add(DoneBox.SelectedItem);
            }

            TaskListBox.Items.Remove(TaskListBox.SelectedItem);
            DoneBox.Items.Remove(DoneBox.SelectedItem);

        }

        private void DoingBox_DragLeave(object sender, DragEventArgs e)
        {

        }

        private void TaskListBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TaskListBox.UnselectAll();
        }

        private void DoneBox_LostFocus(object sender, RoutedEventArgs e)
        {
            DoneBox.UnselectAll();
        }

        private void DoingBox_LostFocus(object sender, RoutedEventArgs e)
        {
            DoingBox.UnselectAll();
        }

        private void TaskListBox_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            if (DoingBox.SelectedIndex != -1)
            {
                TaskListBox.Items.Add(DoingBox.SelectedItem);
            }
            if (DoneBox.SelectedIndex != -1)
            {
                TaskListBox.Items.Add(DoneBox.SelectedItem);
            }

            DoingBox.Items.Remove(DoingBox.SelectedItem);
            DoneBox.Items.Remove(DoneBox.SelectedItem);
        }

        private void DoneBox_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (TaskListBox.SelectedIndex != -1)
            {
                DoneBox.Items.Add(TaskListBox.SelectedItem);
            }
            if (DoingBox.SelectedIndex != -1)
            {
                DoneBox.Items.Add(DoingBox.SelectedItem);
            }

            DoingBox.Items.Remove(DoingBox.SelectedItem);
            TaskListBox.Items.Remove(TaskListBox.SelectedItem);
        }

        private void TaskListBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DoingBox.Items.Add(TaskListBox.SelectedItem);
            TaskListBox.Items.Remove(TaskListBox.SelectedItem);
        }

        private void AddTaskTextBox_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            AddTaskTextBox.Text = "";
        }

        private void AddTaskTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(AddTaskTextBox.Text == "")
            AddTaskTextBox.Text = "Input your todo's here...";
        }

        private void AddTaskTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            AddTaskTextBox.Text = "";
        }

        private void DeleteTasksButton_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        private void DeleteTasksButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete all tasks?", "Warning", MessageBoxButton.YesNoCancel);

            switch(result)
            {
                case MessageBoxResult.Yes:
                    TaskListBox.Items.Clear();
                    DoingBox.Items.Clear();
                    DoneBox.Items.Clear();
                    break;

                case MessageBoxResult.No:
                    break;

                case MessageBoxResult.Cancel:
                    break;
            }
        }

        private void DebugButton_Click(object sender, RoutedEventArgs e)
        {
            TaskListBox.UnselectAll();
            DoingBox.UnselectAll();
            DoneBox.UnselectAll();
            MessageBox.Show("All tasks unselected");
        }

        private void DoingBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DoneBox.Items.Add(DoingBox.SelectedItem);
            DoingBox.Items.Remove(DoingBox.SelectedItem);
        }

        private void DoneBox_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DoneBox.Items.Remove(DoneBox.SelectedItem);
        }
    }
}