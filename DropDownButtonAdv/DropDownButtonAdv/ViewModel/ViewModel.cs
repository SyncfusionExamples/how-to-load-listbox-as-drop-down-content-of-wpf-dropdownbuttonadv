using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropDownButtonAdv
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            items = new ObservableCollection<string>();
            items.Add("Item1");
            items.Add("Item2");
            items.Add("Item3");
            items.Add("Item4");
            items.Add("Item5");
            items.Add("Item6");
            items.Add("Item7");
            items.Add("Item8");
        }

        private ObservableCollection<String> items;

        public ObservableCollection<String> Items
        {
            get { return items; }
            set { items = value; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        private string selectedItem = "Item1";

        public string SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged("SelectedItem"); OnSelectedChanged(value); }
        }

        private void OnSelectedChanged(string SelectedItem)
        {
            //will invoke when Selection changes
        }

    }
}
