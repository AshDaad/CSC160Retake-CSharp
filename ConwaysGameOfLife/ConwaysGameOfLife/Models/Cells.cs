using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife.Models
{
	public class Cells : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyChange([CallerMemberName] string field = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(field));
        }


        private bool isAlive = false;
		public int SuroundingAliveCell { get; set; } = 0;

		public Cells(Board board)
		{
			board.UpdateCellAliveStatus += IsItLiving;
		}

		public bool IsAlive
		{
			get { return isAlive; }
			set {
                isAlive = value;
                NotifyChange();
            }
        }
		private void IsItLiving()
		{

            if ((SuroundingAliveCell == 3) || (this.IsAlive && SuroundingAliveCell == 2))
            {
                this.IsAlive = true;
            }
            else
            {
                this.IsAlive = false;
            }
            //if (SuroundingAliveCell == 3)
            //{
            //    this.IsAlive = true;
            //}
            //if (SuroundingAliveCell < 2 || SuroundingAliveCell > 3)
            //{
            //    this.IsAlive = false;
            //}

            //if (SuroundingAliveCell == 3 || this.IsAlive && SuroundingAliveCell == 2
            //    || this.IsAlive && SuroundingAliveCell == 3)
            //{
            //    this.IsAlive = true;
            //}
            //else
            //{
            //    this.IsAlive = false;
            //}


        }
    }
}
