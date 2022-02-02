using DataBindingexercise.models;
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

namespace DataBindingexercise
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private Furby furby = new Furby();
		public MainWindow()
		{
			InitializeComponent();
			/*
			 * Databinding requires 3 things
			 * 1) Data context - the object that owns the data to be displayed
			 * 2) Path - the property path to the data
			 * 3) Binding Mode - The kind of binding we are using
			 */


			//NameLabel.DataContext = furby;
			//ColorLabel.DataContext = furby;
			//SoulsLabel.DataContext = furby;

			MainPanel.DataContext = furby;

			//this.DataContext = furby;
		}

		private void NewFurbyButton_Click(object sender, RoutedEventArgs e)
		{
			furby.Name = "carl";
			furby.Color = "blood";
			furby.SoulsTaken = int.MaxValue;
			MainPanel.DataContext = furby;

		}
	}
}
