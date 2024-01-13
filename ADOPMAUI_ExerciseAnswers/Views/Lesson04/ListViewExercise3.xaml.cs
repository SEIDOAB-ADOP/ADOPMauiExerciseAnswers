using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson04
{
    public partial class ListViewExercise3 : ContentPage
    {
        public ListViewExercise3()
        {
            InitializeComponent();
            ButtonList.ItemsSource = City.List;
        }

        private async void ButtonList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            City item = (City)e.Item;
            await DisplayAlert("Item Tapped", item.Name, "OK");
            ((ListView)sender).SelectedItem = null;
        }

        private async void MoreButton_Clicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var item = (City)b.CommandParameter;
            await DisplayAlert("Button Clicked", $"{item.Name} in {item.Continent} has a population of {item.Population}.", "OK");
        }
    }
}

