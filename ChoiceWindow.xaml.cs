using Pract44WPF;
using System.Windows;

namespace Pract44WPF
{
    public partial class ChoiceWindow : Window
    {
        public ChoiceWindow()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Visibility = Visibility.Visible;
            this.Close();
        }

        private void ChangeTestButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.frame.Content = new ChangeTestPage();
        }

        private void Start_test_button_OnClick(object sender, RoutedEventArgs e)
        {
            if (TesterClass.Deserialization<TestClass>().Count != 0)
            {
                this.frame.Content = new TestPage();
            }
        }
    }
}