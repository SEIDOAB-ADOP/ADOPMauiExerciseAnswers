using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson05
{
    public partial class ListViewExercise1 : ContentPage
    {
        public ListViewExercise1()
        {
            InitializeComponent();
            DataModelList.ItemsSource = CityPopulation.List;
        }
        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            //Routing of this page
            Title += $"   ({Shell.Current.CurrentState.Location.ToString()})";
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            CityPopulation item = (CityPopulation)e.Item;
            await DisplayAlert("Tapped", item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("../listviewexercise2");
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}

