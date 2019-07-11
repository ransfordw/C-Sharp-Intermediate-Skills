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

namespace _24_Upcasting_And_Downcasting_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // sender. does not have access to the button properties as it is typed as an object
            var button = (Button)sender; // If you know the type being cast is specifically of a certain type
            Button button2 = sender as Button; // returns null if sender cannot be cast into a Button
            if (button2 != null)
            {
                MessageBox.Show(button2.ActualHeight.ToString());
            }

            // button. has access to button options.
            MessageBox.Show("Hello World.");
        }
    }
}
