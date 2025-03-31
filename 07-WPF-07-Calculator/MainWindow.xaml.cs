using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _07_WPF_07_Calculator
{
    enum Operation { None, Add, Subtract, Multiply, Divide }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Operation operation = Operation.None;
        private double lastNumber;
        private string decimalDot = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void NumBtnClick(object sender, RoutedEventArgs e)
        {
            //kdo byl stisknut?
            string digit = ((Button)sender).Content.ToString();

            //nahraď nebo připoj do displeje
            if (DisplayTB.Text == "0")
                DisplayTB.Text = digit;
            else 
                DisplayTB.Text += digit;
        }

        private void DotBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!DisplayTB.Text.Contains(decimalDot))
                DisplayTB.Text += decimalDot;
        }

        private void ACBtn_Click(object sender, RoutedEventArgs e)
        {
            DisplayTB.Text = "0";
        }

        private void PlusMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            DisplayTB.Text = (double.Parse(DisplayTB.Text) * (-1)).ToString();
        }
    }
}