using System;
using System.Collections.Generic;

using ADOPMAUI_Exercise.ViewModels;

namespace ADOPMAUI_Exercise.Views.Lesson06
{
	public partial class NonTrivialBindingExercise4 : ContentPage
	{
		private NonTrivialBindingExercise4_ViewModel _viewModel;

		public NonTrivialBindingExercise4()
		{
			InitializeComponent();

			BindingContext = _viewModel = new NonTrivialBindingExercise4_ViewModel();
        }
	}
}

