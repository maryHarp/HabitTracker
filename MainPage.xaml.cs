using HabitTracker.Models;
using Microsoft.Maui.Controls.Internals;
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
        int setFrequency;
        List <Habit> allHabits = new();
        FormattedString formattedString = new FormattedString();

        private void AddHabit_Pressed(object sender, EventArgs e)
        {
            Habit newHabit = new Habit(NameEntry.Text, DescriptionEntry.Text, (Int32.TryParse(FrequencyEntry.Text, out setFrequency) ? setFrequency : 1));
            allHabits.Add(newHabit);

            formattedString.Spans.Add(new Span { Text = newHabit.Name + "\n", FontSize = 28, FontAttributes = FontAttributes.Bold });
            formattedString.Spans.Add(new Span { Text = newHabit.Description, FontSize = 16 });
            formattedString.Spans.Add(new Span { Text = "\nHow many days a week: " + newHabit.Frequency, FontSize = 11 });

            Label habit = new Label();
            habit.Margin = new Thickness(10);
            habit.WidthRequest = 350;
            habit.HeightRequest = 100;
            habit.BackgroundColor = Colors.Beige;
            habit.FormattedText = formattedString;
            habit.HorizontalTextAlignment = TextAlignment.Center;
            habit.LineBreakMode = LineBreakMode.WordWrap;

            Button edit = new Button();
            edit.Text = "Edit";
            edit.HorizontalOptions = LayoutOptions.End;
            edit.VerticalOptions = LayoutOptions.Center;
            
            edit.Clicked += (s, e) => { /*Button logic here*/ };

            Habits.Children.Add(habit);
            Habits.Children.Add(edit);

            NameEntry.Text = "";
            DescriptionEntry.Text = "";
            FrequencyEntry.Text = "";
        }
    }
}
