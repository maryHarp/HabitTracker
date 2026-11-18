namespace HabitTracker
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object? sender, EventArgs e)
        {
            // Handle login logic here
        }
        private async void OnSignUpClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }
    }
}