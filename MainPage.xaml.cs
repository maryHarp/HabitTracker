using HabitTracker.Models;
using Microsoft.Maui.Graphics;
using System.Security.Cryptography.X509Certificates;

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
            List <Habit> allHabits = new();
            Habit newHabit = new Habit() { Goal=BasicTextEntry.Text, CreationDate=1, Identifier=1, Streak=1};
            allHabits.Add(newHabit);

            for (int i = 0; i < allHabits.Count(); i++ )
            {
                Label child = new Label() { Text=allHabits.ElementAt(i).Goal, FontSize=28};
                Habits.Add(child);
            }
        }
    }
}
