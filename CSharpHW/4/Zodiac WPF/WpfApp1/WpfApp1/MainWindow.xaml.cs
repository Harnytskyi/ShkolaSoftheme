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

namespace WpfApp1
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

        private void userDate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
        private DateTime GetBirthDay()
        {
            DateTime birthday;

            string strDate = userDate.Text.ToString();
            string[] arrDate = strDate.Split('/');
            
                int day = Int32.Parse(arrDate[0]);
                int month = Int32.Parse(arrDate[1]);
                int year = Int32.Parse(arrDate[2]);
                birthday = new DateTime(year, month, day);
            
            return birthday;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (userDate.Text == null)
                return;
            else
            { 
            var birthday = GetBirthDay();
                YourZodiac(birthday);
            }
                
            

        }
        private void YourZodiac(DateTime birthday)
        {
            Console.Write("Your zodiac sign is: ");
            if ((birthday.Day >= 20 && birthday.Month == 1) || birthday.Day < 19 && birthday.Month == 2)
            {
                userSignLabel.Content = ("Aquarius");
                imageSign.Source = new BitmapImage(new Uri(@"aquarius.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 19 && birthday.Month == 2) || birthday.Day < 21 && birthday.Month == 3)
            {
                userSignLabel.Content = ("Pisces");
                imageSign.Source = new BitmapImage(new Uri(@"pisces.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 21 && birthday.Month == 3) || birthday.Day < 20 && birthday.Month == 4)
            {
                userSignLabel.Content = ("Aries");
                imageSign.Source = new BitmapImage(new Uri(@"aries.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 20 && birthday.Month == 4) || birthday.Day < 21 && birthday.Month == 5)
            {
                userSignLabel.Content = ("Taurus");
                imageSign.Source = new BitmapImage(new Uri(@"taurus.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 21 && birthday.Month == 5) || birthday.Day < 21 && birthday.Month == 6)
            {
                userSignLabel.Content = ("Gemini");
                imageSign.Source = new BitmapImage(new Uri(@"gemini.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 21 && birthday.Month == 6) || birthday.Day < 23 && birthday.Month == 7)
            {
                userSignLabel.Content = ("Cancer");
                imageSign.Source = new BitmapImage(new Uri(@"cancer.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 23 && birthday.Month == 7) || birthday.Day < 23 && birthday.Month == 8)
            {
                userSignLabel.Content = ("Leo");
                imageSign.Source = new BitmapImage(new Uri(@"leo.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 23 && birthday.Month == 8) || birthday.Day < 23 && birthday.Month == 9)
            {
                userSignLabel.Content = ("Virgo");
                imageSign.Source = new BitmapImage(new Uri(@"virgo.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 23 && birthday.Month == 9) || birthday.Day < 23 && birthday.Month == 10)
            {
                userSignLabel.Content = ("Libra");
                imageSign.Source = new BitmapImage(new Uri(@"libra.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 23 && birthday.Month == 10) || birthday.Day < 22 && birthday.Month == 11)
            {
                userSignLabel.Content = ("Scorpio");
                imageSign.Source = new BitmapImage(new Uri(@"scorpio.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 22 && birthday.Month == 11) || birthday.Day < 22 && birthday.Month == 12)
            {
                userSignLabel.Content = ("Sagittarius");
                imageSign.Source = new BitmapImage(new Uri(@"sagittarius.jpg", UriKind.Relative));
            }
            else if ((birthday.Day >= 22 && birthday.Month == 12) || birthday.Day < 20 && birthday.Month == 1)
            {
                userSignLabel.Content = ("Capricorn");
                imageSign.Source = new BitmapImage(new Uri(@"capricorn.jpg", UriKind.Relative));
            }
        }
    }
}
