using ADOPMAUI_Exercise.Models;

namespace ADOPMAUI_Exercise.Views.Lesson02;


public partial class SetProperties1 : ContentPage
{
    int _idx = 0;
    List<NamedColor> _colors = NamedColor.All.ToList();

    public SetProperties1()
    {
        InitializeComponent();

        _idx = _colors.FindIndex(c => c.FriendlyName == "Coral");

        lblWelcome.Text = $"{_colors[_idx].FriendlyName} ({_idx})";
        lblColorBox.Color = _colors[_idx].Color;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        _idx++;
        if (_idx >= _colors.Count)
        {
            _idx = 0;
        }


        lblWelcome.Text = $"{_colors[_idx].FriendlyName} ({_idx})";
        lblColorBox.Color = _colors[_idx].Color;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        _idx--;
        if (_idx < 0)
        {
            _idx = _colors.Count - 1;
        }

        lblWelcome.Text = $"{_colors[_idx].FriendlyName} ({_idx})";
        lblColorBox.Color = _colors[_idx].Color;

    }
}