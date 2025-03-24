using Microsoft.Win32;
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

namespace _07_WPF_06_FotoView
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

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            //vyvolat dialog
            OpenFileDialog ofd = new();
            ofd.Title = "Select picture";
            //ofd.Filter = "JPEG (*.jpg; *.jpeg)|*.jpg;*.jpeg";
            ofd.Filter =
                "All supported graphics|*.jpg;*.jpeg;*.png;*.bmp|"
                + "JPEG (*.jpg; *.jpeg)|*.jpg;*.jpeg|"
                + "PNG (*.png)|*.png";

            if (ofd.ShowDialog() != true)
                return; // ukončím načítání, uživatel udělal CANCEL

            //co tedy vybral?
            string filename = ofd.FileName;

            //ukážu
            FileNameTB.Text = filename;

            //zkusím načíst
            try
            {
                Uri imageUri = new Uri(filename);

                PhotoCtrl.Source = new BitmapImage(imageUri);
            }
            catch
            {
                MessageBox.Show("Error opening file", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}