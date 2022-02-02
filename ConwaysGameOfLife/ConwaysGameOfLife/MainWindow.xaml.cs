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
using ConwaysGameOfLife.Models;
using ConwaysGameOfLife.Properties;
using ConwaysGameOfLife.Converters;

namespace ConwaysGameOfLife
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		GameController GameController = new GameController();
        Random rand = new Random();

		public MainWindow()
		{
			InitializeComponent();
			this.DataContext = GameController;
            GenerateBoard();
		}

		private void AutoToggle(object sender, RoutedEventArgs e)
		{
			GameController.PlayItself = !GameController.PlayItself;
		}

		private void StepClick(object sender, RoutedEventArgs e)
		{
			GameController.Tick();
		}

		private void RemakeBoard_Click(object sender, RoutedEventArgs e)
		{
			GameController.Board = new Board(GameController.GridWidth, GameController.GridHeight);
            GenerateBoard();
		}

		private void RandomizeCells(object sender, RoutedEventArgs e)
		{
            for (int i = 0; i < GameController.Board.Height; i++)
            {
                for (int j = 0; j < GameController.Board.Width; j++)
                {
                    int val = rand.Next(0, 101);

                    if (val < GameController.LivingPercent)
                    {
                        GameController.Board.Cells[j, i].IsAlive = true;
                    }
                    else
                    {
                        GameController.Board.Cells[j, i].IsAlive = false;
                    }

                }
            }
        }

		public void GenerateBoard()
		{
            
			Board.Children.Clear();
            Board.ColumnDefinitions.Clear();
            Board.RowDefinitions.Clear();


            for (int x = 0; x < GameController.Board.Width; x++)
            {
                Board.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int y = 0; y < GameController.Board.Height; y++)
            {
                Board.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < GameController.Board.Height; i++)
            {
                for (int j = 0; j < GameController.Board.Width; j++)
                {
                    Label CellLabel = new Label()
                    {
                        DataContext = GameController.Board.Cells[j, i]
                    };
                    Binding cellBinding = new Binding("IsAlive")
                    {
                        Converter = new CellConverter()
                    };

                    CellLabel.SetBinding(BackgroundProperty, cellBinding);
                    CellLabel.MouseDown += CellLabel_MouseDown;

                    CellLabel.Margin = new Thickness(.5);

                    Grid.SetColumn(CellLabel, j);
                    Grid.SetRow(CellLabel, i);

                    Board.Children.Add(CellLabel);
                }
            }
        }

        private void CellLabel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Cells source = (sender as Label).DataContext as Cells;
            source.IsAlive = !source.IsAlive;
        }
    }
}
