using Microsoft.VisualBasic;

namespace HousingAlgorithm
{
    internal class Program
    {
        private static int score = 0;
        private static string userInput = "";

        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Housing Score Calculator");
            Console.WriteLine("Please answer the following questions to calculate your housing score. " +
                "Our algorithm prioritzes those students who have long commutes and are in good academic standing.");

            Console.WriteLine("\nQuestion 1: What class year are you in?");
            userInput = Console.ReadLine().ToLower();
            determineGrade();

            Console.WriteLine("\nGreat! For these next questions please answer yes or no. \nQuestion 2: Are you a fulltime student?");
            userInput = Console.ReadLine().ToLower();
            fullTime();

            Console.WriteLine("\nQuestion 3: Are you disabled or need assistance on campus?");
            userInput = Console.ReadLine().ToLower();
            disability();

            Console.WriteLine("\nQuestion 4: Do you receive finiacial aid or have earned scholarships?");
            userInput = Console.ReadLine().ToLower();
            aid();

            Console.WriteLine("\nQuestion 5: Is your commute greater than 60 minutes?");
            userInput = Console.ReadLine().ToLower();
            commute();

            Console.WriteLine("\nQuestion 6: Are you on the high honor roll?");
            userInput = Console.ReadLine().ToLower();
            honorRole();

            Console.WriteLine("\nQuestion 7: Are you in good academic standing?");
            userInput = Console.ReadLine().ToLower();
            academicStanding();

            Console.WriteLine("\nQuestion 8: Have you had disciplinary action taken against you?");
            userInput = Console.ReadLine().ToLower();
            disciplinary();


            Console.WriteLine("\nYour calculated housing score was: " + score);
        }

        private static void determineGrade()
        {
            switch (userInput)
            {
                case "senior":
                    score += 1;
                    break;
                case "junior":
                    score += 1;
                    break;
                case "sophomore":
                    score += 2;
                    break;
                case "freshman":
                    score += 2;
                    break;
                default:
                    Console.WriteLine("Invalid Response Try Again");
                    userInput = Console.ReadLine();
                    determineGrade();
                    break;
            }
        }

        private static void fullTime()
        {
            switch (userInput)
            {
                case "yes":
                    score += 3;
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Invalid Response Try Again");
                    userInput = Console.ReadLine();
                    fullTime(); 
                    break;
            }
        }

        private static void disability()
        {
            switch (userInput)
            {
                case "yes":
                    score += 4;
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Invalid Response Try Again");
                    userInput = Console.ReadLine();
                    disability();
                    break;
            }
        }

        private static void aid()
        {
            switch (userInput)
            {
                case "yes":
                    score += 2;
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Invalid Response Try Again");
                    userInput = Console.ReadLine();
                    aid();
                    break;
            }
        }

        private static void commute()
        {
            switch (userInput)
            {
                case "yes":
                    score += 5;
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Invalid Response Try Again");
                    userInput = Console.ReadLine();
                    commute();
                    break;
            }
        }

        private static void honorRole()
        {
            switch (userInput)
            {
                case "yes":
                    score += 1;
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Invalid Response Try Again");
                    userInput = Console.ReadLine();
                    honorRole();
                    break;
            }
        }
        private static void academicStanding()
        {
            switch (userInput)
            {
                case "yes":
                    break;
                case "no":
                    score += -2;
                    break;
                default:
                    Console.WriteLine("Invalid Response Try Again");
                    userInput = Console.ReadLine();
                    academicStanding();
                    break;
            }
        }
        private static void disciplinary()
        {
            switch (userInput)
            {
                case "yes":
                    score += -3;
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Invalid Response Try Again");
                    userInput = Console.ReadLine();
                    disciplinary();
                    break;
            }
        }
    }
}
