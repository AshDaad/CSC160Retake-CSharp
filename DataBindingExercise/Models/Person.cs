using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Extension_Lib;

namespace DataBindingExercise.Models
{
    class Person : INotifyPropertyChanged
    {
        private Random rnd = new Random();
        private List<string> firstNames = new List<string> { "Chloe", "Edmond", "Martha", "Arthora", "Medb" };
        private List<string> lastNames = new List<string> { "Andersen", "Dantes", "Liang", "Kyrielight", "Mae" };
        private string name = "";
        private int age;
        private string gender = "";

        public event PropertyChangedEventHandler PropertyChanged;

        protected void FieldChanged([CallerMemberName] string field = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(field));
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                FieldChanged();
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                FieldChanged();
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                FieldChanged();
            }
        }

        public void GenerateName()
        {
            string f = firstNames.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
            string l = lastNames.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
            Name = string.Format("{0} {1}", f, l);

        }
        public void GenerateAge()
        {
            Age = rnd.Next(115) + 5;
        }
        public void GenerateGender()
        {
            int x = rnd.Next(2);
            if (x == 0)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }
        }



    }
}


    // Name
    // - First : List = {Chloe, Edmond, Martha, Arthora, Medb}
    // - Last : List = {Andersen, Dantes, Liang, Kyrielight, Mae}


    // Age
    // Randomly, between 5 and 120
        // rand.Naxt(114)+6
    

    // Gender
    // Male or Female