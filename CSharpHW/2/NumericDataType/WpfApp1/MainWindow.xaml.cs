using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (numericType.SelectedItem as ListBoxItem);

            switch (selectedItem.Content)
            {
                case "sbyte":
                    ShowSbyteValue();
                    break;
                case "byte":
                    ShowByteValue();
                    break;
                case "short":
                    ShowShortValue();
                    break;
                case "ushort":
                    ShowUshortValue();
                    break;
                case "int":
                    ShowIntValue();
                    break;
                case "uint":
                    ShowUintValue();
                    break;
                case "long":
                    ShowLongValue();
                    break;
                case "ulong":
                    ShowUlongValue();
                    break;
                case "float":
                    ShowFloatValue();
                    break;
                case "double":
                    ShowDoubleValue();
                    break;
                case "decimal":
                    ShowDecimalValue();
                    break;
            }
        }
        private void ShowSbyteValue()
        {
            minValue.Content = sbyte.MinValue.ToString();
            maxValue.Content = sbyte.MaxValue.ToString();
        }
        private void ShowByteValue()
        {
            minValue.Content = byte.MinValue.ToString();
            maxValue.Content = byte.MaxValue.ToString();
        }
        private void ShowShortValue()
        {
            minValue.Content = short.MinValue.ToString();
            maxValue.Content = short.MaxValue.ToString();
        }
        private void ShowUshortValue()
        {
            minValue.Content = ushort.MinValue.ToString();
            maxValue.Content = ushort.MaxValue.ToString();
        }
        private void ShowIntValue()
        {
            minValue.Content = int.MinValue.ToString();
            maxValue.Content = int.MaxValue.ToString();
        }
        private void ShowUintValue()
        {
            minValue.Content = uint.MinValue.ToString();
            maxValue.Content = uint.MaxValue.ToString();
        }
        private void ShowLongValue()
        {
            minValue.Content = long.MinValue.ToString();
            maxValue.Content = long.MaxValue.ToString();
        }
        private void ShowUlongValue()
        {
            minValue.Content = ulong.MinValue.ToString();
            maxValue.Content = ulong.MaxValue.ToString();
        }
        private void ShowFloatValue()
        {
            minValue.Content = float.MinValue.ToString();
            maxValue.Content = float.MaxValue.ToString();
        }
        private void ShowDoubleValue()
        {
            minValue.Content = double.MinValue.ToString();
            maxValue.Content = double.MaxValue.ToString();
        }
        private void ShowDecimalValue()
        {
            minValue.Content = decimal.MinValue.ToString();
            maxValue.Content = decimal.MaxValue.ToString();
        }
    }
}
