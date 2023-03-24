using System;

class SaraPersonalityZodiac
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thanks for taking Sara's zodiac Test");

  
            Console.Write("Please enter your Month of Birth: ");
	    
	    string monthOfBirth = Console.ReadLine();

            string zodiacSign = "";
            if (monthOfBirth == 1 )
            {
                zodiacSign = "Aquarius";
            }
            else if (monthOfBirth == 2 )
            {
                zodiacSign = "Pisces";
            }
            else if (monthOfBirth == 3 )
            {
                zodiacSign = "Aries";
            }
            else if (monthOfBirth == 4 )
            {
                zodiacSign = "Taurus";
            }
            else if (monthOfBirth == 5 )
            {
                zodiacSign = "Gemini";
            }
            else if (monthOfBirth == 6 )
            {
                zodiacSign = "Cancer";
            }
            else if ((monthOfBirth == 7)
            {
                zodiacSign = "Leo" ;
            }
            else if (monthOfBirth == 8)
            {
                zodiacSign = "Virgo";
            }
            else if (monthOfBirth == 9)
            {
                zodiacSign = "Libra";
            }
            else if (monthOfBirth == 10)
            {
                zodiacSign = "Scorpio";
            }
            else if (monthOfBirth == 11)
            {
                zodiacSign = "Sagittarius";
            }
            else if (monthOfBirth == 12)
            {
                zodiacSign = "Capricorn";
            }

	    string partner = "";
	    switch (zodiacSign)
	    {
		    case "Aquarius":
			    partner = "Capricorn";
			    break;
		    case "Pisces":
			    partner = "Aquarius";
			    break;
		    case "Capricorn":
			    partner = "Pisces";
			    break;
		    case "Sagittarus":
			    partner = "Scorpio";
			    break;
		    case "Scorpio":
			    partner = "Sagittarus";
			    break;
		    case "Virgo":
			    partner = "Libra"
				    break;
		    case "Aires":
		    	   partner = "Aquarius";
		           break;
		    case "Leo":
			    partner = "Cancer";
			    break;
		    case "Cancer":
			    partner = "Leo";
			    break;
		    case "Gemini":
			    partner = "Taurus";
			    break;
		    case "Taurus":
			    partner = "Gemini";
			    break;
		    case "Libra":
			    partner = "Virgo";
			    break;
		    default:
			    partner = "Aquarius"
			    break;
	    }
		     Console.WriteLine("Your Partner is "+partner);

       }}}
