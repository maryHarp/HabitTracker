using System;
using System.Collections.Generic;
using System.Text;

namespace HabitTracker
{
    public class NameValidity
    {
        string name;

        public void SetName(string inputName)
        {
            bool validName = false;
            while (!validName)
            {
                if(!inputName.IsWhiteSpace())
                {
                    name = inputName;
                    validName = true;
                }
            }
        }

       
    }
}
