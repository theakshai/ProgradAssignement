using System;

class SaraPersonalityTest {
             public void PersonalityBasedOnAge(int age)
            {

                if (age < 18)
                {
                    Console.WriteLine("Charisma and Energy is overflowing with you.");
                }
                else if (age >= 18 && age < 40)
                {
                    Console.WriteLine("Building each step for climbing the success mountain in your life.");
                }
                else
                {
                    Console.WriteLine("You experienced the Success and became wise to help others.");
                }
            }

            public void PersonalityBasedOnGender(string gender)
            {

                if (gender.Equals("M"))
                {
                    Console.WriteLine("You are strong and hardworking personality");
                }
                else
                {
                    Console.WriteLine("You have caring and loving personality");
                }
            }

            public void PersonalityBasedOnNature(string nature)
            {

                if (nature.Equals("Air"))
                {
                    Console.WriteLine("Being Calm is your nature");
                }
                else
                {
                    Console.WriteLine("Being Calm is your nature");
                }
            }

       static void Main(string[] args) {
       
        Console.WriteLine("Thanks for taking Sara's Personality Test");
        
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter your gender(Male/Female/NotPreferedToSay): ";
        string gender = Console.ReadLine();

        Console.Write("Enter what you like in these Air/Water:  ");
        string nature = Console.ReadLine();
        SaraPersonalityTest s = new SaraPersonalityTest();
        s.PersonalityBasedOnAge(age);
        s.PersonalityBasedOnGender(gender);
        s.PersonalityBasedOnNature(nature);
        }  
}
}
