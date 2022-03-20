using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace WpfExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<String> Items
        {
            get { return new List<String> { "One", "Two", "Three" }; }
        }
        public MainWindow()
        {
            Application.Current.Properties["MyName"] = "Leon";

            DataContext = this;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }
        private new void KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            MessageBox.Show("Key down: "  + e.Key);
        }

        private void HelpCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
            MessageBox.Show("CanExecute");
        }

        private void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("HelpExecuted");
        }

        protected override void OnClosed(EventArgs e)
        {
            MessageBox.Show("On closed");
            base.OnClosed(e);
        }

        private void ListBox_Selected_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            MessageBox.Show($"Selected Item is: {ListBox_Selected.SelectedValue.ToString()}");
        }
    }
}
