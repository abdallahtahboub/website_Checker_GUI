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

namespace website_Checker_GUI
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string test1;




        public MainWindow()
        {
            InitializeComponent();
            alarm_1.Visibility = Visibility.Hidden;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {






        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            test1 = test.Text;
            bool testme = checker.checkWebsiteStatus(test1);
            if (testme == true)
            {
                alarm_1.Background = new SolidColorBrush(Colors.Green);
                alarm_1.Visibility = Visibility.Visible ;

            }

            if (testme == false)
            {
                alarm_1.Background = new SolidColorBrush(Colors.Red);
                alarm_1.Visibility = Visibility.Visible;

            }

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }
    }
}
