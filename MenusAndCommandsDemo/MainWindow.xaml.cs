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

namespace MenusAndCommandsDemo
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

        //This was our first Close handler that simply prints a message.
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Why you tryin' to close me, bro?!");
        }

        //This is our current Close handler that prints a message AND closes the application
        private void OtherClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ok, I'll really close this time.");
            Application.Current.Shutdown();
        }

        //This is the Save handler that prints a message
        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Saving... Saved!");
        }
    }
}
