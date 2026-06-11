
// EXCEEDING REQUIREMENTS
// I Added a Level System.

GoalManager manager = new GoalManager();

bool running = true;

while (running)
{
    Console.Clear();

    Console.WriteLine("==================================");
    Console.WriteLine("        ETERNAL QUEST");
    Console.WriteLine("==================================");
    Console.WriteLine($"Current Score: {manager.GetScore()}");
    Console.WriteLine($"Current Level: {manager.GetLevel()}");
    Console.WriteLine();

    Console.WriteLine("Menu Options:");
    Console.WriteLine("1. Create New Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Record Event");
    Console.WriteLine("4. Save Goals");
    Console.WriteLine("5. Load Goals");
    Console.WriteLine("6. Quit");

    Console.Write("\nSelect a choice from the menu: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":

            Console.WriteLine("\nThe types of Goals are:");

            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");

            Console.Write("Which type of goal would you like to create? ");
            string goalType = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            if (goalType == "1")
            {
                manager.AddGoal(
                    new SimpleGoal(
                        name,
                        description,
                        points));

                Console.WriteLine("Simple Goal created successfully!");
            }
            else if (goalType == "2")
            {
                manager.AddGoal(
                    new EternalGoal(
                        name,
                        description,
                        points));

                Console.WriteLine("Eternal Goal created successfully!");
            }
            else if (goalType == "3")
            {
                Console.Write("How many times does this goal need to be accomplished? ");
                int targetCount = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        targetCount,
                        bonus));

                Console.WriteLine("Checklist Goal created successfully!");
            }
            else
            {
                Console.WriteLine("Invalid goal type selected.");
            }

            break;

        case "2":

            Console.WriteLine("\nYour Goals:");

            manager.DisplayGoals();

            break;

        case "3":

            Console.WriteLine("\nSelect a Goal to Record:");

            manager.DisplayGoals();

            Console.Write("Enter goal number: ");

            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            manager.RecordGoal(goalIndex);

            break;

        case "4":

            Console.WriteLine("\nSave functionality not yet implemented.");

            // Example:
            // manager.SaveGoals("goals.txt");

            break;

        case "5":

            Console.WriteLine("\nLoad functionality not yet implemented.");

            // Example:
            // manager.LoadGoals("goals.txt");

            break;

        case "6":

            running = false;

            Console.WriteLine("Thank you for using Eternal Quest!");

            break;

        default:

            Console.WriteLine("Invalid menu option.");

            break;
    }

    if (running)
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}

