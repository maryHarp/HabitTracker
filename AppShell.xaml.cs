namespace HabitTracker
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("EditPage", typeof(EditPage));
        }
    }
}
