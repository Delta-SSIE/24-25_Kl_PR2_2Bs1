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

namespace _07_WPF_03_O_Deset_Vic;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InputTB_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (OutputTB == null)
            return;

        try
        {
            double num = double.Parse(InputTB.Text);
            double result = num + 10;
            OutputTB.Text = result.ToString();
            OutputTB.Background = Brushes.Transparent;
            OutputTB.Foreground = Brushes.Black;
            OutputTB.FontWeight = FontWeights.Normal;
        }
        catch (FormatException)
        {
            OutputTB.Text = "NaN";
            OutputTB.Background = Brushes.Red;
            OutputTB.Foreground = Brushes.White;
            OutputTB.FontWeight = FontWeights.Bold;
        }
    }
}