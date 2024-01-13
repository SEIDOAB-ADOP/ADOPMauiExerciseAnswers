using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ADOPMAUI_Exercise.Models;
using ADOPMAUI_Exercise.Services;

namespace ADOPMAUI_Exercise.Views.Lesson06
{
    public partial class ActivityProgressExercise : ContentPage
    {
        PrimeNumberService service = new PrimeNumberService();

        public ActivityProgressExercise()
        {
            InitializeComponent();
        }
        public ActivityProgressExercise(int NrBatches) : this()
        {
            enNrBatches.Text = NrBatches.ToString();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Code here will run right before the screen appears
            //You want to set the Title or set the City

            //This is making the first load of data
            MainThread.BeginInvokeOnMainThread(async () => { await LoadPrimes(); });
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await LoadPrimes();
        }
        private async Task LoadPrimes()
        {
            if (!int.TryParse(enNrBatches.Text, out int result)) return;

            var progressReporter = new Progress<float>(async value =>
            {
                progressBar1.Progress = value;
                await progressBar2.ProgressTo(value, 750, Easing.Linear);

            });

            progressBar1.Progress = 0;
            progressBar2.Progress = 0;

            int nrbatches = result;
            layBusy.IsVisible = true;
            activityIndicator.IsRunning = true;
            lvPrimes.IsVisible = false;

            lvPrimes.ItemsSource = await service.GetPrimeBatchCountsAsync(nrbatches, progressReporter);

            lvPrimes.IsVisible = true;
            activityIndicator.IsRunning = false;
            layBusy.IsVisible = false;
        }

        private async void lvPrimes_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (PrimeBatch)e.Item;
            await DisplayAlert("Primed", $"Between integer {item.BatchStart} and {item.BatchEnd} there are {item.NrPrimes} primes", "Got it!");
        }
    }
}