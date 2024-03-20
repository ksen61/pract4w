using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Pract44WPF
{
    public partial class TestPage : Page
    {
        private int count = 0;
        private int countright = 0;
        private List<TestClass> Tests = TesterClass.Deserialization<TestClass>();
        public TestPage()
        {
            InitializeComponent();
            change_elemets(0);
        }

        private void Answer1testbuttonOnClick(object sender, RoutedEventArgs e)
        {
            check(AnswerEnum.First, count);
            change_elemets(count);
        }

        private void Answer2testbuttonOnClick(object sender, RoutedEventArgs e)
        {
            check(AnswerEnum.Second, count);
            change_elemets(count);
        }

        private void Answer3testbuttonOnClick(object sender, RoutedEventArgs e)
        {
            check(AnswerEnum.Third, count);
            change_elemets(count);
        }

        private void check(AnswerEnum answer_of_user, int index)
        {
            if (answer_of_user == Tests[index].Rightanswer)
            {
                countright += 1;
            }
            if (count + 1 <= Tests.Count)
            {
                count += 1;
                change_elemets(count);
            }
        }

        private void change_elemets(int index)
        {
            if (count + 1 <= Tests.Count)
            {
                name_of_test_textblock.Text = Tests[index].Name;
                description_of_test_textblock.Text = Tests[index].Description;
                Answer1testbutton.Content = Tests[index].Answer1;
                Answer2testbutton.Content = Tests[index].Answer2;
                Answer3testbutton.Content = Tests[index].Answer3;
            }
            else
            {
                name_of_test_textblock.Text = "Количество правильных ответов: " + countright.ToString();
                description_of_test_textblock.Text = "";
                Answer1testbutton.Content = "";
                Answer2testbutton.Content = "";
                Answer3testbutton.Content = "";
                Answer1testbutton.IsEnabled = false;
                Answer2testbutton.IsEnabled = false;
                Answer3testbutton.IsEnabled = false;
            }
        }
    }
}
