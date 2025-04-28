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

namespace _07_WPF_08_Pexeso
{
    /// <summary>
    /// Interaction logic for Card.xaml
    /// </summary>
    public partial class Card : UserControl
    {
        public bool IsFlipped => CardBack.Visibility == Visibility.Hidden;

        public string Symbol
        {
            get { return (string)GetValue(SymbolProperty); }
            set { SetValue(SymbolProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Symbol.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.Register("Symbol", typeof(string), typeof(Card), new PropertyMetadata(""));


        public Card()
        {
            InitializeComponent();
        }

        public void Flip()
        {
            //if (IsFlipped)
            //{
            //    CardBack.Visibility = Visibility.Visible;
            //}
            //else
            //{
            //    CardBack.Visibility = Visibility.Hidden;
            //}
            CardBack.Visibility = IsFlipped ? Visibility.Visible : Visibility.Hidden;
        }
    }
}
