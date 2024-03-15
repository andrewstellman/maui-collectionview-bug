using System.Collections.ObjectModel;

namespace MauiCards
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Card> myItems = new ObservableCollection<Card>();

        public MainPage()
        {
            InitializeComponent();

            MyItems.ItemsSource = myItems;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            myItems.Add(
               new Card((Values)Random.Shared.Next(1, 14), (Suits)Random.Shared.Next(4)));
        }

        private void MyItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyItems.SelectedItem == null)
                SelectedCard.Text = $"No card selected";
            else
                SelectedCard.Text = $"You selected {MyItems.SelectedItem}";
        }

    }

}
