using HabitTracker.Models;

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

        private void AddHabit_Pressed(object sender, EventArgs e)
        {
            Habit newHabit = new Habit() { Goal="Test", CreationDate=1, Identifier=1, Streak=1};
            Label child = new Label() { Text=newHabit.Goal, FontSize=28};

            //Binding b = new Binding(path: "Text", source: BasicTextEntry, mode: BindingMode.OneWay);

            //Habits.SetBinding(Label.TextProperty, b);

            Habits.Add(child);
        }
    }
}
