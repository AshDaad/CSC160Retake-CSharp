using DataBindingExercise.Models;
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

namespace DataBindingExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private Person person = new Person();

        public MainWindow()
        {
            InitializeComponent();
            MainGrid.DataContext = person;
        }

        private void Close_Button_Click(object sender, RoutedEventArgs e)
        {
            SystemCommands.CloseWindow(this);
        }

        private void Randomise_Button_Click(object sender, RoutedEventArgs e)
        {
            ((Person)NameOutputLabel.DataContext).GenerateName();
            ((Person)AgeOutputLabel.DataContext).GenerateAge();
            ((Person)GenderOutputLabel.DataContext).GenerateGender();
        }
    }
}
