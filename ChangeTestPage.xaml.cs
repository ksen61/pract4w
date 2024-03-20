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

namespace Pract44WPF
{
    public partial class ChangeTestPage : Page
    {
        private List<TestClass> UpdatedTests = TesterClass.Deserialization<TestClass>();
        public ChangeTestPage()
        {
            InitializeComponent();
            updated_test_datagrid.ItemsSource = UpdatedTests;
        }

        private void AddNewStringButton_OnClick(object sender, RoutedEventArgs e)
        {
            TestClass new_test_class = new TestClass("", "", "", "", "", AnswerEnum.First);
            UpdatedTests.Add(new_test_class);
            updated_test_datagrid.ItemsSource = null;
            updated_test_datagrid.ItemsSource = UpdatedTests;
        }

        private void DeleteStringButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (UpdatedTests.Count != 0)
            {
                UpdatedTests.RemoveAt(UpdatedTests.Count - 1);
                updated_test_datagrid.ItemsSource = null;
                updated_test_datagrid.ItemsSource = UpdatedTests;
            }
        }

        private void SaveStringsButton_OnClick(object sender, RoutedEventArgs e)
        {
            TesterClass.Serialization(UpdatedTests);
            updated_test_datagrid.ItemsSource = null;
            updated_test_datagrid.ItemsSource = UpdatedTests;
        }
    }
}
