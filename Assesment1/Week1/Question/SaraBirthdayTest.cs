using System;

class SaraBirthdayTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thanks For taking Sara Birthay Calendar Personality Test: ");

            DateTime currentDate = DateTime.Now;

           
            Console.Write("Please enter your birthdate (MM/DD/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            int age = currentDate.Year - birthdate.Year;
            if (birthdate > currentDate.AddYears(-age))
            {
                age--;
            }

        
            DateTime nextBirthday = birthdate.AddYears(age);
            if (nextBirthday < currentDate)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }
            int daysUntilNextBirthday = (nextBirthday - currentDate).Days;

            Console.WriteLine("Your age is "+ age);
            Console.WriteLine("Your next birthday is " + nextBirthday.ToShortDateString());
            Console.WriteLine("Days Remaining unitl next BirthDay" + daysUntilNextBirthday);
        }
    }
}
