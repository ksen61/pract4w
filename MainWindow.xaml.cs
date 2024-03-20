using Pract44WPF;
using System.Windows;

namespace Pract44WPF
{
    public partial class MainWindow : Window
    {

        public string AdminPassword = "пароль";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeTestClick(object sender, RoutedEventArgs e)
        {
            ChoiceWindow test_window = new ChoiceWindow();
            test_window.Owner = this;
            Visibility = Visibility.Collapsed;
            if (admin_key_textbox.Text == AdminPassword)
            {
                test_window.ChangeTestButton.IsEnabled = true;
                test_window.frame.Content = new NoTestPage();
                test_window.Show();
            }
            else
            {
                test_window.ChangeTestButton.IsEnabled = false;
                test_window.frame.Content = new NoTestPage();
                test_window.Show();
            }
        }

        private void StartTestClick(object sender, RoutedEventArgs e)
        {
            ChoiceWindow test_window = new ChoiceWindow();
            test_window.ChangeTestButton.IsEnabled = false;
            test_window.frame.Content = new NoTestPage();
            test_window.Owner = this;
            Visibility = Visibility.Collapsed;
            test_window.Show();
        }
    }
}
