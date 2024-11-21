using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOPMAUI_Exercise.ViewModels;

namespace ADOPMAUI_Exercise.Views.Lesson06
{
    public partial class NonTrivialBindingExercise2 : ContentPage
    {
        private NonTrivialBindingExercise2_ViewModel _viewModel;

        public NonTrivialBindingExercise2()
        {
            InitializeComponent();

            BindingContext = _viewModel = new NonTrivialBindingExercise2_ViewModel { SliderValue = 0.2F, StepperValue = 2 };
        }


        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await DisplayAlert("Instance Values", 
                $"SliderValue {_viewModel.SliderValue}\nStepperValue {_viewModel.StepperValue}", "OK");


        }
    }

    public class NonTrivialBindingExercise2_ViewModel : BaseViewModel //Inheritance Step 4
    {
        
        float _slidervalue;
        public float SliderValue
        {
            set => Set<float>(ref _slidervalue, value);
            get => _slidervalue;
        }

        int _steppervalue;
        public int StepperValue
        {
            set => Set<int>(ref _steppervalue, value);
            get => _steppervalue;
        }

        #region Step 1
        Command _SetMiddleCommand;
        public Command SetMiddleCommand => _SetMiddleCommand ?? (_SetMiddleCommand =
            new Command(() =>
            {
                SliderValue = 0.5F;
                StepperValue = 5;
            }));
        #endregion
    }
}