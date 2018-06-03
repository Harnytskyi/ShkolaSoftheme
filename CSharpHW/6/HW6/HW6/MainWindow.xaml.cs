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

namespace HW6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Run();
        }
        public int RandomNumber { get; set; }
        public int i = 3;
        public void Run()
        {
            i = 3;
            RandomNumber = GenerateNumber();
        }

        public int GenerateNumber()
        {
            return new Random().Next(1, 11);
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                int guess = int.Parse(guessBox.Text);
                if (guessBox.Text.Length <= 0)
                {
                    throw new InvalidOperationException("Number not entered");
                }
                else if ((guess < 1) || (guess > 10))
                {
                    throw new InvalidOperationException("Number must be between 1 and 10");
                }

            result.Content = RandomNumber;
            if (RandomNumber == guess)
                {
                    result.Content = "You guess";
                    Run();
                }
                else
                {
                    i--;
                    result.Content = ("Number of attempts : " + i);
                    guessBox.Text = "";
                }
                if (i == 0)
                {

                    result.Content = ("You lose");
                    Run();
                }
            }
            
            catch (InvalidOperationException ex)
            {
                result.Content = ex.Message;
            }
            catch (FormatException ex)
            {
                result.Content = ex.Message;
            }
            catch (Exception ex)
            {
                result.Content = ex.Message;
            }
        }
    }
}
