using HabitTracker.Models;
using Microsoft.Maui.Graphics;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace HabitTracker
{
    public partial class MainPage : ContentPage
    {       
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddHabit_Pressed(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameEntry.Text))
            {
                string setName = NameEntry.Text;
            }

            if(!string.IsNullOrWhiteSpace(DescriptionEntry.Text))
            {
                string setDescription = DescriptionEntry.Text;
            }

            int setFrequency = (Int32.TryParse(FrequencyEntry.Text, out setFrequency) ? setFrequency : 1);
            if (setFrequency > 7)
            {
                setFrequency = 7;
            }
            List <Habit> allHabits = new();
            Habit newHabit = new Habit(NameEntry.Text, DescriptionEntry.Text, setFrequency);
            allHabits.Add(newHabit);

            for (int i = 0; i < allHabits.Count(); i++ )
            {
                Label child = new Label() { Text=allHabits.ElementAt(i).Name, FontSize=28};
                Label child2 = new Label() { Text=allHabits.ElementAt(i).Description, FontSize=28};
                Label child3 = new Label() { Text=allHabits.ElementAt(i).Frequency + "", FontSize=28};
                Habits.Add(child);
                Habits.Add(child2);
                Habits.Add(child3);
            }

            NameEntry.Text = "";
            DescriptionEntry.Text = "";
            FrequencyEntry.Text = "";
        }
    }
}
