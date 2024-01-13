using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson02;


public partial class SetProperties2 : ContentPage
{
	int _idx = 0;
	List<NamedColor> _colors = NamedColor.All.ToList();

	public SetProperties2()
	{
		InitializeComponent();
        lblColorBox.Color = _colors[_idx % 5].Color;

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _idx++;
        lblColorBox.Color = _colors[_idx % 5].Color;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

    }
}