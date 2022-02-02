using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ConwaysGameOfLife.Models
{
	public class GameController : INotifyPropertyChanged
	{

        #region GET THESE OUT OF MY FACE, I CAN'T SEE!!!1!!1
        public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyChange([CallerMemberName] string field = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(field));
		}

		public DispatcherTimer Timer { get; set; }

		private int speed;

		public int Speed
		{
			get { return speed; }
			set
			{
				speed = value;
				NotifyChange();
				//Timer.Interval = TimeSpan.FromTicks(Speed);
				Timer.Interval = TimeSpan.FromSeconds((Double)1/Speed);
            }
		}

		private int gridWidth;

		public int GridWidth
		{
			get { return gridWidth; }
			set
			{
				gridWidth = value;
				NotifyChange();
			}
		}

		private int gridHeight;

		public int GridHeight
		{
			get { return gridHeight; }
			set
			{
				gridHeight = value;
				NotifyChange();
			}
		}

		private bool playItself;

		public bool PlayItself
		{
			get { return playItself; }
			set
			{
				playItself = value;
				NotifyChange();
			}
		}

		private Board board;

		public Board Board
		{
			get { return board; }
			set
			{
				board = value;
			}
		}
        
        private double livingPercent;

		public double LivingPercent
		{
			get { return livingPercent; }
			set
			{
                if(0 <= value && value <= 100)
                {
                    livingPercent = value;
                }
                else if (value > 100)
                {
                    value = 100;
                }
                else
                {
                    value = 1;
                }
				
				NotifyChange();
			}
		}
        

		public void Tick()
		{
			Board.Tick();
		}

        #endregion

        public GameController()
        {
            Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Start();
            GridHeight = 30;
            GridWidth = 30;
            PlayItself = false;
            LivingPercent = 23;
            Speed = 45;
            Board = new Board(GridWidth, GridHeight);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (PlayItself)
            {
                Board.Tick();
            }
        }
    }
}
