using Syncfusion.SfRadialMenu.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RadialCommandSample
{
    public  class ViewModel : INotifyPropertyChanged
    { 
        private ICommand item1Command;
        public ICommand Item1Command
        {
            get { return item1Command; }
            set
            {
                item1Command = value;
                OnPropertyRaised("Item1Command");
            }
        }

        private ICommand item2Command;
        public ICommand Item2Command
        {
            get { return item2Command; }
            set
            {
                item2Command = value;
                OnPropertyRaised("Item2Command");
            }
        }

        private ICommand item3Command;
        public ICommand Item3Command
        {
            get { return item3Command; }
            set
            {
                item3Command = value;
                OnPropertyRaised("Item3Command");
            }
        }

        private ICommand item4Command;
        public ICommand Item4Command
        {
            get { return item4Command; }
            set
            {
                item4Command = value;
                OnPropertyRaised("Item4Command");
            }
        }

        private ICommand item5Command;
        public ICommand Item5Command
        {
            get { return item5Command; }
            set
            {
                item5Command = value;
                OnPropertyRaised("Item5Command");
            }
        }

        Page page;

        public ViewModel(Page page)
        {
            this.page = page;
            Item1Command = new Command(ButtonClicked);
            Item2Command = new Command(ButtonClicked);
            Item3Command = new Command(ButtonClicked);
            Item4Command = new Command(ButtonClicked);
            Item5Command = new Command(ButtonClicked);
        }

        private async void ButtonClicked(object sender)
        {
            var text = (sender as string).ToString();
            await page.DisplayAlert("Alert", text, "OK");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }

        }
    }
}
