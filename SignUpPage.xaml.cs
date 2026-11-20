namespace HabitTracker;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private async void OnSignUpClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }
}