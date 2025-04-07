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
        private Operation lastOperation = Operation.None;
        private double lastNumber;
        private string decimalDot = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;


        public string DisplayText
        {
            get { return (string)GetValue(DisplayTextProperty); }
            set { SetValue(DisplayTextProperty, value); }
        }

        public static readonly DependencyProperty DisplayTextProperty =
            DependencyProperty.Register("DisplayText", typeof(string), typeof(MainWindow), new PropertyMetadata(""));



        public MainWindow()
        {
            InitializeComponent();
            DisplayText = "0";
        }

        private void NumBtnClick(object sender, RoutedEventArgs e)
        {
            //kdo byl stisknut?
            string digit = ((Button)sender).Content.ToString();

            //nahraď nebo připoj do displeje
            if (DisplayText == "0")
                DisplayText = digit;
            else
                DisplayText += digit;
        }

        private void DotBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!DisplayText.Contains(decimalDot))
                DisplayText += decimalDot;
        }

        private void ACBtn_Click(object sender, RoutedEventArgs e)
        {
            DisplayText = "0";
        }

        private void PlusMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            DisplayText = (double.Parse(DisplayText) * (-1)).ToString();
        }

        private void PercentBtn_Click(object sender, RoutedEventArgs e)
        {
            DisplayText = (double.Parse(DisplayText) / 100).ToString();
        }

        private void OperationBtn_Click(object sender, RoutedEventArgs e)
        {
            string symbol = (sender as Button).Content.ToString();
            Operation operation = symbol switch
            {
                "+" => Operation.Add,
                "−" => Operation.Subtract,
                "×" => Operation.Multiply,
                "/" => Operation.Divide,
                _ => Operation.None
            };

            //pokud je zapamatovaná operace, vykonej
            if (lastOperation != Operation.None)
            {
                //zapamatuj si výsledek a operaci
                double currentNum = double.Parse(DisplayText);
                lastNumber = Calculate(currentNum);
            }

            //jinak si zapamatuj displej a operaci
            else
            {
                lastNumber = double.Parse(DisplayText);
            }
            lastOperation = operation;
            DisplayText = "0";

        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            double currentNum = double.Parse(DisplayText);
            double result = Calculate(currentNum);

            DisplayText = result.ToString();
            lastOperation = Operation.None;
        }

        private double Calculate(double currentNum)
        {
            return lastOperation switch
            {
                Operation.Add => SimpleMath.Add(lastNumber, currentNum),
                Operation.Subtract => SimpleMath.Subtract(lastNumber, currentNum),
                Operation.Divide => SimpleMath.Divide(lastNumber, currentNum),
                Operation.Multiply => SimpleMath.Multiply(lastNumber, currentNum),
                _ => 0
            };
        }
    }
}