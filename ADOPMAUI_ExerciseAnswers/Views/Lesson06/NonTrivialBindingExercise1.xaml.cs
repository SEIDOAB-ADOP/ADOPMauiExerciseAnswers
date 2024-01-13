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
    public partial class NonTrivialBindingExercise1 : ContentPage
    {

        #region Step 3
        private NonTrivialBindingExercise1_ViewModel _viewModel;
        #endregion

        public NonTrivialBindingExercise1()
        {
            InitializeComponent();

            #region Step 3
            BindingContext = _viewModel = new NonTrivialBindingExercise1_ViewModel { SliderValue = 0.2F, StepperValue = 2 };
            #endregion
        }

        #region Step 2
        private void Button_Clicked(object sender, EventArgs e)
        {
            mySlider.Value = mySlider.Maximum / 2;
            myStepper.Value = myStepper.Maximum / 2;
        }
        #endregion

        #region Step 5
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            _viewModel.SliderValue = 0.5F;
            _viewModel.StepperValue = 5;
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await DisplayAlert("Instance Values", 
                $"SliderValue {_viewModel.SliderValue}\nStepperValue {_viewModel.StepperValue}", "OK");

        }
        #endregion
    }

    #region Step 3 and 4
    public class NonTrivialBindingExercise1_ViewModel : BaseViewModel //Inheritance Step 4, BaseViewModel in namespace ADOPMAUI_Exercise.ViewModels
    {
        #region Step 3
        
        //public float SliderValue { get; set; }
        //public int StepperValue { get; set; }
        
        #endregion

        
        #region Step 4
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
        #endregion
    }
    #endregion
}