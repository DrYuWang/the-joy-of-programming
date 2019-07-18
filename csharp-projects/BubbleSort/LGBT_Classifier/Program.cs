using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGBT_Classifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Biological gender
            //- Gender identity (What gender they think they are)
            //- Sexual orientation (Whether they are interested in men, women or both or none.)

            Console.WriteLine("What is your biological gender?\n(enter 'm' for male and 'f' for female.)");
            string biologicalGender = Console.ReadLine();
            Console.WriteLine("What do you identify as (what gender you thing you are)?\n(enter 'm' for male and 'f' for female.)");
            string genderIdentity = Console.ReadLine();
            Console.WriteLine("What is your sexual orientation (interested in 'm'ales, 'f'emales or 'b'oth)?");
            string sexualOrientation = Console.ReadLine();

            bool lesbian = (biologicalGender == "f" && genderIdentity == "f" && sexualOrientation == "f") ||
                           (biologicalGender == "m" && genderIdentity == "f" && sexualOrientation == "f");
            bool gay = (biologicalGender == "m" && genderIdentity == "m" && sexualOrientation == "m") ||
                       (biologicalGender == "f" && genderIdentity == "m" && sexualOrientation == "m");

            bool bisexual = sexualOrientation == "b";
            bool transgender = (biologicalGender == "f" && genderIdentity == "m") ||
                               (biologicalGender == "m" && genderIdentity == "f");

            bool straight = (biologicalGender == "f" && genderIdentity == "f" && sexualOrientation == "m") ||
                            (biologicalGender == "m" && genderIdentity == "m" && sexualOrientation == "f");

            if (lesbian)
            {
                Console.WriteLine("You are lesbian.");
            }
            if (gay)
            {
                Console.WriteLine("You are gay");
            }
            if (bisexual)
            {
                Console.WriteLine("You are bisexual");
            }
            if (transgender)
            {
                Console.WriteLine("You are transexual");
            }
            if (straight)
            {
                Console.WriteLine("You are straight");
            }
        }

    }
}
