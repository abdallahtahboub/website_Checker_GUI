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






        public MainWindow()
        {
            InitializeComponent();
            website_1.Visibility = Visibility.Hidden;
            website_2.Visibility = Visibility.Hidden;
            website_3.Visibility = Visibility.Hidden;
            website_4.Visibility = Visibility.Hidden;
            website_5.Visibility = Visibility.Hidden;
            website_6.Visibility = Visibility.Hidden;
            website_7.Visibility = Visibility.Hidden;
            website_8.Visibility = Visibility.Hidden;
            website_9.Visibility = Visibility.Hidden;
            info_1.Visibility = Visibility.Hidden;
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


            string d_1 = domain_1.Text;
            string d_2 = domain_2.Text;
            string d_3 = domain_3.Text;
            string d_4 = domain_4.Text;
            string d_5 = domain_5.Text;
            string d_6 = domain_6.Text;
            string d_7 = domain_7.Text;
            string d_8 = domain_8.Text;
            string d_9 = domain_9.Text;




            bool test_1 = checker.checkWebsiteStatus(d_1);
            bool test_2 = checker.checkWebsiteStatus(d_2);
            bool test_3 = checker.checkWebsiteStatus(d_3);
            bool test_4 = checker.checkWebsiteStatus(d_4);
            bool test_5 = checker.checkWebsiteStatus(d_5);
            bool test_6 = checker.checkWebsiteStatus(d_6);
            bool test_7 = checker.checkWebsiteStatus(d_7);
            bool test_8 = checker.checkWebsiteStatus(d_8);
            bool test_9 = checker.checkWebsiteStatus(d_9);

            if (test_1 == true)
            {
                website_1.Background = new SolidColorBrush(Colors.Green);
                website_1.Visibility = Visibility.Visible;
                info_1.Foreground = new SolidColorBrush(Colors.Green);
                info_1.Visibility = Visibility.Visible;

            }
            if (test_1 == false)
            {
                website_1.Background = new SolidColorBrush(Colors.Red);
                website_1.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_1.Foreground = new SolidColorBrush(Colors.Red);
                info_1.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }

            //if (test_2 == true)
            //{
            //    website_2.Background = new SolidColorBrush(Colors.Green);
            //    website_2.Visibility = Visibility.Visible;

            //}
            //if (test_3 == true)
            //{
            //    website_3.Background = new SolidColorBrush(Colors.Green);
            //    website_3.Visibility = Visibility.Visible;

            //}
            //if (test_4 == true)
            //{
            //    website_4.Background = new SolidColorBrush(Colors.Green);
            //    website_4.Visibility = Visibility.Visible;

            //}
            //if (test_5 == true)
            //{
            //    website_5.Background = new SolidColorBrush(Colors.Green);
            //    website_5.Visibility = Visibility.Visible;

            //}
            //if (test_6 == true)
            //{
            //    website_6.Background = new SolidColorBrush(Colors.Green);
            //    website_6.Visibility = Visibility.Visible;

            //}
            //if (test_7 == true)
            //{
            //    website_7.Background = new SolidColorBrush(Colors.Green);
            //    website_7.Visibility = Visibility.Visible;

            //}
            //if (test_8 == true)
            //{
            //    website_8.Background = new SolidColorBrush(Colors.Green);
            //    website_8.Visibility = Visibility.Visible;

            //}
            //if (test_9 == true)
            //{
            //    website_9.Background = new SolidColorBrush(Colors.Green);
            //    website_9.Visibility = Visibility.Visible;

            //}





            //if (test_2 == false)
            //{
            //    website_2.Background = new SolidColorBrush(Colors.Red);
            //    website_2.Visibility = Visibility.Visible;
            //    string myserver = checker.server;
            //    checker.CreateMessage(myserver);
            //}
            //if (test_3 == false)
            //{
            //    website_3.Background = new SolidColorBrush(Colors.Red);
            //    website_3.Visibility = Visibility.Visible;
            //    string myserver = checker.server;
            //    checker.CreateMessage(myserver);
            //}
            //if (test_4 == false)
            //{
            //    website_4.Background = new SolidColorBrush(Colors.Red);
            //    website_4.Visibility = Visibility.Visible;
            //    string myserver = checker.server;
            //    checker.CreateMessage(myserver);
            //}
            //if (test_5 == false)
            //{
            //    website_5.Background = new SolidColorBrush(Colors.Red);
            //    website_5.Visibility = Visibility.Visible;
            //    string myserver = checker.server;
            //    checker.CreateMessage(myserver);
            //}
            //if (test_6 == false)
            //{
            //    website_6.Background = new SolidColorBrush(Colors.Red);
            //    website_6.Visibility = Visibility.Visible;
            //    string myserver = checker.server;
            //    checker.CreateMessage(myserver);
            //}
            //if (test_7 == false)
            //{
            //    website_7.Background = new SolidColorBrush(Colors.Red);
            //    website_7.Visibility = Visibility.Visible;
            //    string myserver = checker.server;
            //    checker.CreateMessage(myserver);
            //}
            //if (test_8 == false)
            //{
            //    website_8.Background = new SolidColorBrush(Colors.Red);
            //    website_8.Visibility = Visibility.Visible;
            //    string myserver = checker.server;
            //    checker.CreateMessage(myserver);
            //}
            //if (test_9 == false)
            //{
            //    website_9.Background = new SolidColorBrush(Colors.Red);
            //    website_9.Visibility = Visibility.Visible;
            //    string myserver = checker.server;
            //    checker.CreateMessage(myserver);
            //}


        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }
    }
}
