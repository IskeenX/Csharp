using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp
{
    class Ordering : INotifyPropertyChanged
    {
        private string name;
        private double price;
        private bool isGlutenfree;

        public bool IsGlutenfree
        {
            get { return isGlutenfree; }
            set { isGlutenfree = value; OnPropertyChanged(); }
        }


        public double Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged(); }
        }


        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
