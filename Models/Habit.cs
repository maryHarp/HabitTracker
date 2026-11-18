using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Models
{
    public class Habit
    {
        public string Goal { get; set; }
        public int Identifier { get; set; }
        public int CreationDate { get; set; }
        public int Streak { get; set; }
    }
}
