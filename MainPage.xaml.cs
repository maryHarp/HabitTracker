namespace HabitTracker
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        //Test Comment (Paxton)2

        public MainPage()
        {
            InitializeComponent();
        }

        public void CheckName(string inputName)
        {
            bool validName = false;
            while (!validName)
            {
                if (!inputName.IsWhiteSpace())
                {
                    //name = inputName;
                    validName = true;
                }
                BasicTextEntry.Placeholder = "This is an invalid input.";
            }
        }

        private void AddhabitButton_Clicked(object sender, EventArgs e)
        {


            bool validName = false;
            while (!validName)
            {
                if (!BasicTextEntry.Text.IsWhiteSpace())
                {
                    //name = inputName;
                    validName = true;
                }
                BasicTextEntry.Placeholder = "This is an invalid input.";
            }
        }
    }
}
