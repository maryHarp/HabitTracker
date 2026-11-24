using HabitTracker.Models;
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

        public bool ChangeHabitName(string name)
        {
            bool validated = Habit.IsValidHabitName(name);
            if (validated)
            {
                // get the specific habit out of list to change the name
                // habit.Name = name;
                return true;
            }
            else return false;

        }
    }
}
