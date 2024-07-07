using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nEnter 'All' or 'all' to operate all challenges starting from Challenge 1.");
            Console.WriteLine("Enter '1' to start Challenge 1.");
            Console.WriteLine("Enter '2' to start Challenge 2.");
            Console.WriteLine("Enter '3' to start Challenge 3.");
            Console.WriteLine("Enter '4' to start Challenge 4.");
            Console.WriteLine("Enter '5' to start the Bonus Challenge.");
            Console.WriteLine("Enter '0' to exit.");
            Console.Write("Please make your choice (input is case insensitive): ");

            string userChoice = Console.ReadLine().ToLower();

            switch (userChoice.ToLower())
            {
                case "all":
                    RunAllChallenges();
                    break;
                case "1":
                    ShowChallengeStart(1);
                    var challenge1 = new Challenge1();
                    challenge1.Run();
                    break;
                case "2":
                    ShowChallengeStart(2);
                    var challenge2 = new Challenge2();
                    challenge2.Run();
                    break;
                case "3":
                    ShowChallengeStart(3);
                    var challenge3 = new Challenge3();
                    challenge3.Run();
                    break;
                case "4":
                    ShowChallengeStart(4);
                    var challenge4 = new Challenge4();
                    challenge4.Run();
                    break;
                case "5":
                    ShowChallengeStart(5);
                    var challengeBonus = new ChallengeBonus();
                    challengeBonus.Run();
                    break;
                case "0":
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid input. Please enter 'All', '1', '2', '3', '4', or '0'.");
                    break;
            }
        }
    }

    static void ShowChallengeStart(int challengeNumber)
    {
        Console.WriteLine($"\n================================== Challenge {challengeNumber} Start! ==================================\n");
    }
    static void RunAllChallenges()
    {
        Console.WriteLine("\nStarting all challenges...\n");

        ShowChallengeStart(1);
        var challenge1 = new Challenge1();
        challenge1.Run();

        ShowChallengeStart(2);
        var challenge2 = new Challenge2();
        challenge2.Run();

        ShowChallengeStart(3);
        var challenge3 = new Challenge3();
        challenge3.Run();

        ShowChallengeStart(4);
        var challenge4 = new Challenge4();
        challenge4.Run();

        ShowChallengeStart(5);
        var challengeBonus = new ChallengeBonus();
        challengeBonus.Run();
    }


}
