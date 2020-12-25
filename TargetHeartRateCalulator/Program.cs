using System;

namespace TargetHeartRateCalulator
{
   class Program
   {
      static void Main(string[] args)
      {
             HeartRates hr1 = new HeartRates();

         Console.WriteLine("Please enter first name: ");
         hr1.FirstName = Console.ReadLine();

         Console.WriteLine("Please enter last name: ");
         hr1.LastName = Console.ReadLine();

         Console.WriteLine("Please enter your year of birth: ");
         hr1.DateOfBirth = Convert.ToInt32(Console.ReadLine());

           

         Console.WriteLine($"Your name is : {hr1.FirstName} { hr1.LastName}");
         Console.WriteLine($"You age is: {hr1.getCurrentAge()}");
         Console.WriteLine($"Your maximum heart rate is: {hr1.getMaxHeartRate()} ");
         Console.WriteLine($"Your target max heart rate is: {hr1.getMaxTargetHeartRate()}");
         Console.WriteLine($"Your target min heart rate is: {hr1.getMinTargetHeartRate()}");

         Console.ReadKey();


      }
   }
   }
