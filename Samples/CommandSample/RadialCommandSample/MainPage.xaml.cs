using Syncfusion.SfRadialMenu.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RadialCommandSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel= new ViewModel(this);
            this.BindingContext = viewModel;
            //SfRadialMenu radialMenu = new SfRadialMenu();
            //ObservableCollection<SfRadialMenuItem> itemCollection = new ObservableCollection<SfRadialMenuItem>();
            //itemCollection.Add(new SfRadialMenuItem() { Text = "Bold", FontSize = 12 , Command = viewModel.Item1Command , CommandParameter = "Bold is tapped"});
            //itemCollection.Add(new SfRadialMenuItem() { Text = "Copy", FontSize = 12 , Command =viewModel.Item2Command, CommandParameter = "Copy is tapped" });
            //itemCollection.Add(new SfRadialMenuItem() { Text = "Paste", FontSize = 12, Command = viewModel.Item3Command , CommandParameter = "Paste is tapped" });
            //itemCollection.Add(new SfRadialMenuItem() { Text = "Undo", FontSize = 12, Command = viewModel.Item4Command, CommandParameter = "Undo is tapped" });
            //itemCollection.Add(new SfRadialMenuItem() { Text = "Color", FontSize = 12, Command = viewModel.Item5Command, CommandParameter = "Color is tapped" });
            //radialMenu.Items = itemCollection;
            //this.Content = radialMenu;
        }
    }
}
