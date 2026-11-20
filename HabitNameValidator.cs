using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HabitTracker
{
    internal class HabitNameValidator
    {
        public static bool TryValidateName(string name, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "Habit name cannot be empty or blank.";
                return false;
            }

            string pattern = @"^[a-zA-z0-9\s]+$";
            if (!Regex.IsMatch(name, pattern))
            {
                errorMessage = "Habit name can only contain letters and numbers.";
                return false;
            }

            errorMessage = string.Empty; 
            return true;
        }
    }
}
