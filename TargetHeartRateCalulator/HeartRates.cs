using System;
using System.Collections.Generic;
using System.Text;

namespace TargetHeartRateCalulator
{
   class HeartRates
   {
      //instance variables

      private int dateOfBirth;

      public string LastName { get; set; }

      public string FirstName { get; set; }

      public int DateOfBirth
      {
         get
         {
            return dateOfBirth;
         }
         set
         {
                if (value >= 1900 && value <= 2020)
                dateOfBirth = value;
         }
      }

      public HeartRates(string ln, string fn, int dob)
      {
         DateOfBirth = dob;
         FirstName = fn;
         LastName = ln;
      }

      public HeartRates()
      {

      }

        public int CurrentYear = DateTime.Now.Year;
      public int getCurrentAge()
      {
            return CurrentYear - DateOfBirth;
      }
      public int getMaxHeartRate()
      {
            return 220 - getCurrentAge();
      }
      public int getMinTargetHeartRate()
      {
            return Convert.ToInt32(getMaxHeartRate() * 0.5);
      }
      public int getMaxTargetHeartRate()
      {
            return Convert.ToInt32(getMaxHeartRate() * 0.85);
      }
   }
}

