using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using ADOPMAUI_Exercise.Globals;
using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson04
{
    public partial class StateManagement1 : ContentPage
    {
        public StateManagement1()
        {
            InitializeComponent();
            lvFriends.ItemsSource = Global.Data.Friends;
            lvCities.ItemsSource = Global.Data.Cities;
            lvColors.ItemsSource = Global.Data.NamedColors;
        }
    }
}

