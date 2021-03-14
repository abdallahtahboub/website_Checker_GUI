using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

        private static Timer aTimer;



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
            website_10.Visibility = Visibility.Hidden;
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







            noContent_1.Visibility = Visibility.Visible;
            noContent_1.Foreground = new SolidColorBrush(Colors.Red);
            noContent_2.Visibility = Visibility.Visible;
            noContent_2.Foreground = new SolidColorBrush(Colors.Black);

            string d_1 = domain_1.Text;
            string d_2 = domain_2.Text;
            string d_3 = domain_3.Text;
            string d_4 = domain_4.Text;
            string d_5 = domain_5.Text;
            string d_6 = domain_6.Text;
            string d_7 = domain_7.Text;
            string d_8 = domain_8.Text;
            string d_9 = domain_9.Text;
            string d_10 = domain_10.Text;




            int test_1 = checker.checkWebsiteStatus(d_1);
            int test_2 = checker.checkWebsiteStatus(d_2);
            int test_3 = checker.checkWebsiteStatus(d_3);
            int test_4 = checker.checkWebsiteStatus(d_4);
            int test_5 = checker.checkWebsiteStatus(d_5);
            int test_6 = checker.checkWebsiteStatus(d_6);
            int test_7 = checker.checkWebsiteStatus(d_7);
            int test_8 = checker.checkWebsiteStatus(d_8);
            int test_9 = checker.checkWebsiteStatus(d_9);
            int test_10 = checker.checkWebsiteStatus(d_10);


            Stopwatch stopwatch = new Stopwatch();

            string numberStr = minutes.Text;
            bool isParsable = Int32.TryParse(numberStr, out int number);
            Thread.Sleep(number * 60000);
            stopwatch.Stop();

            if (test_1 == 0)
            {

                website_1.Background = new SolidColorBrush(Colors.Black);
                website_1.Visibility = Visibility.Visible;
                info_1.Content = "Bitte Domain eintragen!";
                info_1.Foreground = new SolidColorBrush(Colors.Orange);
                info_1.Visibility = Visibility.Visible;

            }
            if (test_1 == 1)
            {

                website_1.Background = new SolidColorBrush(Colors.Green);
                website_1.Visibility = Visibility.Visible;
                info_1.Content = "Site funktioniert!";
                info_1.Foreground = new SolidColorBrush(Colors.Green);
                info_1.Visibility = Visibility.Visible;

            }
            if (test_1 == 2)
            {
                website_1.Background = new SolidColorBrush(Colors.Red);
                website_1.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_1.Content = "Site ist nicht aufrufbar!";
                info_1.Foreground = new SolidColorBrush(Colors.Red);
                info_1.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }


            if (test_2 == 0)
            {

                website_2.Background = new SolidColorBrush(Colors.Black);
                website_2.Visibility = Visibility.Visible;
                info_2.Content = "Bitte Domain eintragen!";
                info_2.Foreground = new SolidColorBrush(Colors.Orange);
                info_2.Visibility = Visibility.Visible;

            }
            if (test_2 == 1)
            {

                website_2.Background = new SolidColorBrush(Colors.Green);
                website_2.Visibility = Visibility.Visible;
                info_2.Content = "Site funktioniert!";
                info_2.Foreground = new SolidColorBrush(Colors.Green);
                info_2.Visibility = Visibility.Visible;

            }
            if (test_2 == 2)
            {
                website_2.Background = new SolidColorBrush(Colors.Red);
                website_2.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_2.Content = "Site ist nicht aufrufbar!";
                info_2.Foreground = new SolidColorBrush(Colors.Red);
                info_2.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }




            if (test_3 == 0)
            {

                website_3.Background = new SolidColorBrush(Colors.Black);
                website_3.Visibility = Visibility.Visible;
                info_3.Content = "Bitte Domain eintragen!";
                info_3.Foreground = new SolidColorBrush(Colors.Orange);
                info_3.Visibility = Visibility.Visible;

            }
            if (test_3 == 1)
            {

                website_3.Background = new SolidColorBrush(Colors.Green);
                website_3.Visibility = Visibility.Visible;
                info_3.Content = "Site funktioniert!";
                info_3.Foreground = new SolidColorBrush(Colors.Green);
                info_3.Visibility = Visibility.Visible;

            }
            if (test_3 == 2)
            {
                website_3.Background = new SolidColorBrush(Colors.Red);
                website_3.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_3.Content = "Site ist nicht aufrufbar!";
                info_3.Foreground = new SolidColorBrush(Colors.Red);
                info_3.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }


            if (test_4 == 0)
            {

                website_4.Background = new SolidColorBrush(Colors.Black);
                website_4.Visibility = Visibility.Visible;
                info_4.Content = "Bitte Domain eintragen!";
                info_4.Foreground = new SolidColorBrush(Colors.Orange);
                info_4.Visibility = Visibility.Visible;

            }
            if (test_4 == 1)
            {

                website_4.Background = new SolidColorBrush(Colors.Green);
                website_4.Visibility = Visibility.Visible;
                info_4.Content = "Site funktioniert!";
                info_4.Foreground = new SolidColorBrush(Colors.Green);
                info_4.Visibility = Visibility.Visible;

            }
            if (test_4 == 2)
            {
                website_4.Background = new SolidColorBrush(Colors.Red);
                website_4.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_4.Content = "Site ist nicht aufrufbar!";
                info_4.Foreground = new SolidColorBrush(Colors.Red);
                info_4.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }




            if (test_5 == 0)
            {

                website_5.Background = new SolidColorBrush(Colors.Black);
                website_5.Visibility = Visibility.Visible;
                info_5.Content = "Bitte Domain eintragen!";
                info_5.Foreground = new SolidColorBrush(Colors.Orange);
                info_5.Visibility = Visibility.Visible;

            }
            if (test_5 == 1)
            {

                website_5.Background = new SolidColorBrush(Colors.Green);
                website_5.Visibility = Visibility.Visible;
                info_5.Content = "Site funktioniert!";
                info_5.Foreground = new SolidColorBrush(Colors.Green);
                info_5.Visibility = Visibility.Visible;

            }
            if (test_5 == 2)
            {
                website_5.Background = new SolidColorBrush(Colors.Red);
                website_5.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_5.Content = "Site ist nicht aufrufbar!";
                info_5.Foreground = new SolidColorBrush(Colors.Red);
                info_5.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }







            if (test_6 == 0)
            {

                website_6.Background = new SolidColorBrush(Colors.Black);
                website_6.Visibility = Visibility.Visible;
                info_6.Content = "Bitte Domain eintragen!";
                info_6.Foreground = new SolidColorBrush(Colors.Orange);
                info_6.Visibility = Visibility.Visible;

            }
            if (test_6 == 1)
            {

                website_6.Background = new SolidColorBrush(Colors.Green);
                website_6.Visibility = Visibility.Visible;
                info_6.Content = "Site funktioniert!";
                info_6.Foreground = new SolidColorBrush(Colors.Green);
                info_6.Visibility = Visibility.Visible;

            }
            if (test_6 == 2)
            {
                website_6.Background = new SolidColorBrush(Colors.Red);
                website_6.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_6.Content = "Site ist nicht aufrufbar!";
                info_6.Foreground = new SolidColorBrush(Colors.Red);
                info_6.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }


            if (test_7 == 0)
            {

                website_7.Background = new SolidColorBrush(Colors.Black);
                website_7.Visibility = Visibility.Visible;
                info_7.Content = "Bitte Domain eintragen!";
                info_7.Foreground = new SolidColorBrush(Colors.Orange);
                info_7.Visibility = Visibility.Visible;

            }
            if (test_7 == 1)
            {

                website_6.Background = new SolidColorBrush(Colors.Green);
                website_6.Visibility = Visibility.Visible;
                website_7.Content = "Site funktioniert!";
                website_7.Foreground = new SolidColorBrush(Colors.Green);
                website_7.Visibility = Visibility.Visible;

            }
            if (test_7 == 2)
            {
                website_7.Background = new SolidColorBrush(Colors.Red);
                website_7.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_7.Content = "Site ist nicht aufrufbar!";
                info_7.Foreground = new SolidColorBrush(Colors.Red);
                info_7.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }




            if (test_8 == 0)
            {

                website_8.Background = new SolidColorBrush(Colors.Black);
                website_8.Visibility = Visibility.Visible;
                info_8.Content = "Bitte Domain eintragen!";
                info_8.Foreground = new SolidColorBrush(Colors.Orange);
                info_8.Visibility = Visibility.Visible;

            }
            if (test_8 == 1)
            {

                website_8.Background = new SolidColorBrush(Colors.Green);
                website_8.Visibility = Visibility.Visible;
                info_8.Content = "Site funktioniert!";
                info_8.Foreground = new SolidColorBrush(Colors.Green);
                info_8.Visibility = Visibility.Visible;

            }
            if (test_8 == 2)
            {
                website_8.Background = new SolidColorBrush(Colors.Red);
                website_8.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_8.Content = "Site ist nicht aufrufbar!";
                info_8.Foreground = new SolidColorBrush(Colors.Red);
                info_8.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }


            if (test_9 == 0)
            {

                website_9.Background = new SolidColorBrush(Colors.Black);
                website_9.Visibility = Visibility.Visible;
                info_9.Content = "Bitte Domain eintragen!";
                info_9.Foreground = new SolidColorBrush(Colors.Orange);
                info_9.Visibility = Visibility.Visible;

            }
            if (test_9 == 1)
            {

                website_9.Background = new SolidColorBrush(Colors.Green);
                website_9.Visibility = Visibility.Visible;
                info_9.Content = "Site funktioniert!";
                info_9.Foreground = new SolidColorBrush(Colors.Green);
                info_9.Visibility = Visibility.Visible;

            }
            if (test_9 == 2)
            {
                website_9.Background = new SolidColorBrush(Colors.Red);
                website_9.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_9.Content = "Site ist nicht aufrufbar!";
                info_9.Foreground = new SolidColorBrush(Colors.Red);
                info_9.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }

            if (test_10 == 0)
            {

                website_10.Background = new SolidColorBrush(Colors.Black);
                website_10.Visibility = Visibility.Visible;
                info_10.Content = "Bitte Domain eintragen!";
                info_10.Foreground = new SolidColorBrush(Colors.Orange);
                info_10.Visibility = Visibility.Visible;

            }
            if (test_10 == 1)
            {

                website_10.Background = new SolidColorBrush(Colors.Green);
                website_10.Visibility = Visibility.Visible;
                info_10.Content = "Site funktioniert!";
                info_10.Foreground = new SolidColorBrush(Colors.Green);
                info_10.Visibility = Visibility.Visible;

            }
            if (test_10 == 2)
            {
                website_10.Background = new SolidColorBrush(Colors.Red);
                website_10.Visibility = Visibility.Visible;
                string myserver = checker.server;
                info_10.Content = "Site ist nicht aufrufbar!";
                info_10.Foreground = new SolidColorBrush(Colors.Red);
                info_10.Visibility = Visibility.Visible;
                checker.CreateMessage(myserver);
            }




        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
    }
}
