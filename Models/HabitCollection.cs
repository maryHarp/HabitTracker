using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Models
{
    public class HabitCollection
    {
        private List<Habit> _habitList;

        public HabitCollection()
        {
            _habitList = LoadList();
        }

        private static List<Habit> LoadList()
        {
            throw new NotImplementedException();
            // TODO: Connect to MongoDB
            // If list is null, make empty
            // TODO: Grab user and pull correct habit collection
            // If list is empty, maybe prompt user that there are none and to create one as a suggestion
        }

        private static void SaveList()
        {
            throw new NotImplementedException();
            // TODO: Before user exits program, the list must be saved so no data is lost
            // When people make changes, they should confirm to save changes
        }

        private static void RetreiveList()
        {
            throw new NotImplementedException();
            // TODO: Separate method to call back data so we're not consistently making calls to the database (don't brick the database type shit)
            // TODO: When editing the list, all calls will go through the collection first before we
            //          save to database entirely. 
        }

        public static void AddHabit(Habit habit)
        {
            // TODO: Paxton's Functionality
        }

        public static void DeleteHabit(Habit habit, int index)
        {
            // TODO: Mary's Functionality
        }

    }
}
