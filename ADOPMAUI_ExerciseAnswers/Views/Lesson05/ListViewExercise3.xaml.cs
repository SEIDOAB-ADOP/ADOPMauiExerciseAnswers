using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson05
{
    public partial class ListViewExercise3 : ContentPage
    {
        public ListViewExercise3()
        {
            InitializeComponent();
            ButtonList.ItemsSource = City.List;
        }
        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            //Routing of this page
            Title += $"   ({Shell.Current.CurrentState.Location.ToString()})";
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
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("../listviewexercise4");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("../listviewexercise2");
        }
    }
}

