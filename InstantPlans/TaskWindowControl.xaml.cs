﻿namespace InstantPlans
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

        private void ToDoLabel_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void DoingBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.All;
        }


        private void TaskListBox_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (TaskListBox.Items.Count == 0)
                return;

            if (TaskListBox.SelectedItem == null)
                return;

            //MessageBox.Show(TaskListBox.SelectedItem.GetType().ToString());
            // int index = TaskListBox.SelectedItem.ToString();

            if (e.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
            {

                string s = TaskListBox.SelectedItem.ToString();
                
                DragDrop.DoDragDrop(DoingBox, s, DragDropEffects.All);
            }

            //TaskListBox.Items.Remove(TaskListBox.SelectedItem);
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
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                e.Effects = DragDropEffects.All;
            else
                e.Effects = DragDropEffects.None;
            //MessageBox.Show(e.AllowedEffects.ToString());
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
            //MessageBox.Show("Task added");
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
            //MessageBox.Show("LULW");
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
            //MessageBox.Show("Task added");
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
    }
}