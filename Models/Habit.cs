using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker.Models
{
    public class Habit
    {
        private static int count = 0;
        private const int MinFrequency = 1;
        private const int MaxFrequency = 7;
        private const float MinProgress = 0.0f;
        private const float MaxProgress = 100.0f;
        private const int DeactivateChecker = 7;
        private const float ProgressChecker = 80.0f;
        private int _id;
        private string _name;
        private string _description;
        private int _frequency;
        private bool _isActive;
        private float _progressRate;
        private DateTime _creationDate;

        public Habit(string name, string description, int frequency)
        {
            Id = count;
            Name = name;
            Description = description;
            Frequency = frequency;
            Active = true;
            Progress = 0.0f;
            CreationDate = DateTime.UtcNow;
        }

        public int Id
        {
            get { return _id; }
            private set
            {
                _id = count;
                count++;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be null or blank.");
                _name = value;
            }
        }

        public string Description
        {
            get { return _description; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Description cannot be null or blank.");
                _description = value;
            }
        }

        public int Frequency
        {
            get { return _frequency; }
            private set
            {
                if (value < MinFrequency || value > MaxFrequency) throw new ArgumentException("Frequency must be between 1 and 7 (inclusive).");
                _frequency = value;
            }
        }

        /**
         * Sets _isActive false if habit date is less than or equal to DeactivateChecker.
         * If date is greater than DeactivateChekcer, set _isActive false is _progressRate is greater than ProgressChecker.
         * Sets _isActive true if either conditions are met.
         */

        public bool Active
        {
            get { return _isActive; }
            private set
            {
                if (ActiveDaysTotal() <= DeactivateChecker) _isActive = false;
                else if (_progressRate >= ProgressChecker) _isActive = false;
                else _isActive = true;
            }
        }

        public float Progress
        {
            get { return _progressRate; }
            private set
            {
                if (value < MinProgress || value > MaxProgress) throw new ArgumentException("Progress must be between 0 and 100 (inclusive).");
                _progressRate = value;
            }
        }

        public DateTime CreationDate { get; private set; }

        private int ActiveDaysTotal()
        {
            DateTime now = DateTime.UtcNow;
            return (now.Date - _creationDate.Date).Days + 1;
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Description}, {Frequency}, {Active}, {Progress}, {CreationDate}";
        }
    }
}
