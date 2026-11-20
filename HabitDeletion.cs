using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker
{
    class HabitDeletion
    {using System.Collections.ObjectModel;
using System.Threading.Tasks;
using HabitTracker.Models;

namespace HabitTracker.Services
    {
        public class HabitDeleter
        {
            public async Task DeleteHabit(/* Habit habitToDelete, HabitList habitList*/)
            {
                if (habitToDelete == null || habitList == null)
                    return;

                var currentPage = Application.Current?.Windows[0].Page;
                if (currentPage == null)
                    return;

                bool userConfirmed = await currentPage.DisplayAlertAsync(
                    "Delete Habit",
                    $"Are you sure you want to delete '{habitToDelete.Name}'?",
                    "Yes",
                    "No");

                if (userConfirmed)
                {
                    habitList.Remove(habitToDelete);
                }
            }
        }
    }

}
}
