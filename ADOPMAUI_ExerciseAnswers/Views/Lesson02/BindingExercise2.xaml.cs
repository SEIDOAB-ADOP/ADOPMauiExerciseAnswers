namespace ADOPMAUI_Exercise.Views.Lesson02;

public partial class BindingExercise2 : ContentPage
{
	public BindingExercise2()
	{
		InitializeComponent();
        stackLayout.BindingContext = slider2;
    }
}