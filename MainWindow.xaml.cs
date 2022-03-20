using System;
using System.Windows;
using System.Windows.Input;

namespace WpfExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Application.Current.Properties["MyName"] = "Leon";
            MessageBox.Show($"Property set to: {Application.Current.Properties["MyName"]}");

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
    }
}
