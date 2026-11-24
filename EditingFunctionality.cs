using System;
using System.Collections.Generic;
using System.Text;


namespace HabitTracker
{
    class EditingFunctionality
    {
        public async Task OnOptionsClicked(object? sender, EventArgs e)
        {
            //switch to display options for editing
            //HabitTracker.EditPage options = new HabitTracker.EditPage();
            
        }

        public bool ChangeHabitName(string name)
        {
            bool validated = HabitNameValidator.TryValidateName(name, "error message");
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
