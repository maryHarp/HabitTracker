using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker
{
    class EditingFunctionality
    {
        private async Task OnOptionsClicked(object? sender, EventArgs e)
        {
            //switch to display options for editing
            //HabitTracker.EditPage options = new HabitTracker.EditPage();
            await Shell.Current.GoToAsync(nameof(EditPage));
        }

        public bool ChangeHabitName(/*Habit habit, */string name )
        {
            //habit.Name(name);
            return true;
        }

    }
}
