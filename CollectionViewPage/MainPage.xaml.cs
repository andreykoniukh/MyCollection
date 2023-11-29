using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;


namespace CollectionViewPage
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Grid grid = new Grid();
            var toList = new ObservableCollection<ItemsForList>();
            toList.Add(new ItemsForList("One"));
            toList.Add(new ItemsForList("Two"));
            toList.Add(new ItemsForList("Three"));
            mycollectionView.ItemsSource = toList;
            mycollectionViewFrame.ItemsSource = toList;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;


        }

        private  void mycollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             DisplayAlert("Hello", "world","Ok");
        }
    }
    public class ItemsForList
    {
        public ItemsForList(string newValue)
        {
            Value = newValue;
        }
        public string Value { get; set; }

    }
}
