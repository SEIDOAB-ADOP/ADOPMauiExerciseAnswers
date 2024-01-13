using System;
using System.Collections.Generic;

using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson04
{
    public partial class ListViewExercise2 : ContentPage
    {
        public ListViewExercise2()
        {
            InitializeComponent();
            ImageList.ItemsSource = CityPicture.List;
        }

        private async void ImageList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            CityPicture item = (CityPicture)e.Item;
            await DisplayAlert("Tapped", item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}

