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
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            MessageBox.Show("Key down: "  + e.Key);
        }

        void HelpCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
            MessageBox.Show("CanExecute");
        }

        void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("HelpExecuted");
        }
    }
}
