namespace ADOPMAUI_Exercise.Views.Lesson02;

public partial class BindingExercise1 : ContentPage
{
	public BindingExercise1()
	{
		InitializeComponent();

        label2.SetBinding(Label.RotationProperty, new Binding("Value", source: slider2a));
        label2.SetBinding(Label.ScaleProperty, new Binding("Value", source: slider2b));
        label2.SetBinding(Label.OpacityProperty, new Binding("Value", source: slider2c));
    }
}