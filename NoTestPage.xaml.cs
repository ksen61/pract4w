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
    public partial class NoTestPage : Page
    {
        public NoTestPage()
        {
            InitializeComponent();
            if (TesterClass.Deserialization<TestClass>().Count == 0)
            {
                UserCuelTextBlock.Text = "В тесте пока еще нет ни одного вопроса. \n Подождите пока появятся вопросы!";
            }
        }
    }
}
