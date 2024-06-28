using System.IO;
using System;
using System.Collections.Generic;

class Menu
{
    public static void ProgramMenu()
    {
        Console.Clear();
        string points = "0";
        List<string> listOfGoals = new();
        while (true)
        {
            if (points == null)
            {
                points = "0";
            }
            int levelPoints = int.Parse(points);
            int level = levelPoints / 100;
            Console.WriteLine($"You have {points} points!");
            Console.WriteLine($"You are level {level}");
            Console.WriteLine("Welcome to the Eternal Goals program! Your choices are below:\n");
            Console.Write("    1: Create New Goal\n    2: List Goals\n    3: Save Goals\n    4: Load Goals\n    5: Record Event\n    6: Quit\n");
            Console.Write("Please Type Your Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                Console.Clear();
                    Console.WriteLine("   (1) Simple\n   (2) Eternal\n   (3) Checklist\nChoose a Goal type:\n ");
                    string goalChoice = Console.ReadLine();
                    // Simple Goal
                    if (goalChoice == "1")
                    {
                        Simple simpleGoal = new Simple("", "", 0);
                        string newgoal = simpleGoal.RunSimple();
                        listOfGoals.Add(newgoal);
                    }
                    // Eternal Goal
                    else if (goalChoice == "2")
                    {
                        Eternal eternalGoal = new Eternal("", "", 0);
                        string newgoal = eternalGoal.RunEternal();
                        listOfGoals.Add(newgoal);
                    }
                    // Checklist Goal
                    else if (goalChoice == "3")
                    {
                        Checklist checklistGoal = new Checklist("", "", 0);
                        string newGoal = checklistGoal.RunChecklist();
                        Console.WriteLine("How many times should this goal be able to be completed?");
                        string maxTimes = Console.ReadLine();
                        Console.WriteLine("How many points will you get for completing this goal the full number of times?");
                        string bonus = Console.ReadLine();
                        string completedTimes = "0";
                        newGoal = newGoal + ":" + completedTimes + ":" + maxTimes + ":" + bonus;
                        listOfGoals.Add(newGoal);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Returning to Menu...");
                    }
                    break;

                case "2":
                    Console.Clear();
                    for (int i = 0; i < listOfGoals.Count; i++)
                    {
                        string processedGoal = ProcessGoal(listOfGoals[i]);
                        Console.WriteLine($"{i + 1}. {processedGoal}");
                    }
                    break;

                case "3":
                Console.Clear();
                    Console.WriteLine("Please enter the name of the file to save to.\n");
                    string fileName = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine(points);
                        foreach (string goal in listOfGoals)
                        {
                            outputFile.WriteLine(goal);
                        }
                    }
                    break;

                case "4":
                Console.Clear();
                    Console.WriteLine("Enter the name of the file you want to load\n");
                    string filename = Console.ReadLine();
                    string[] lines = File.ReadAllLines(filename);
                    
                    if (lines.Length > 0)
                    {
                        // The first line contains the points
                        points = lines[0];
                        
                        // Clear the current list of goals before loading new ones
                        listOfGoals.Clear();

                        // Remaining lines contain the goals
                        for (int i = 1; i < lines.Length; i++)
                        {
                            listOfGoals.Add(lines[i]);
                        }
                    }
                    break;

                case "5":
                    Console.Clear();

                    // Display the list of goals with an index
                    for (int i = 0; i < listOfGoals.Count; i++)
                    {
                        string processedGoal = ProcessGoal(listOfGoals[i]);
                        Console.WriteLine($"{i + 1}. {processedGoal}");
                    }

                    // Prompt the user to select a goal to mark as completed
                    Console.WriteLine("Enter the number of the goal you completed:");
                    int goalIndex;
                    if (int.TryParse(Console.ReadLine(), out goalIndex) && goalIndex > 0 && goalIndex <= listOfGoals.Count)
                    {
                        // Update the status of the selected goal
                        int index = goalIndex - 1;
                        string goal = listOfGoals[index];
                        string[] parts = goal.Split(':');

                        // Check if the goal is a Simple Goal and not already completed
                        if (parts[0] == "Simple Goal" && parts[1] != "[X]")
                        {
                            parts[1] = "[X]";
                            listOfGoals[index] = string.Join(":", parts);

                            // Update the user's points
                            int goalPoints;
                            if (int.TryParse(parts[4], out goalPoints))
                            {
                                int currentPoints;
                                if (int.TryParse(points, out currentPoints))
                                {
                                    currentPoints += goalPoints;
                                    points = currentPoints.ToString();
                                }
                            }
                        }
                        else if (parts[0] == "Eternal Goal")
                        {
                            listOfGoals[index] = string.Join(":", parts);

                            // Update the user's points
                            int goalPoints;
                            if (int.TryParse(parts[4], out goalPoints))
                            {
                                int currentPoints;
                                if (int.TryParse(points, out currentPoints))
                                {
                                    currentPoints += goalPoints;
                                    points = currentPoints.ToString();
                                }
                            }
                        }
                        else if (parts[0] == "Checklist Goal")
                        {
                            int completedTimes;
                            if (int.TryParse(parts[5], out completedTimes))
                            {
                                int maxTimes;
                                if (int.TryParse(parts[6], out maxTimes))
                                {
                                    // Increment completed times
                                    completedTimes++;
                                    parts[5] = completedTimes.ToString();

                                    // Check if the goal is completed
                                    if (completedTimes <= maxTimes)
                                    {
                                        int goalPoints;
                                        if (int.TryParse(parts[4], out goalPoints))
                                        {
                                            int currentPoints;
                                            if (int.TryParse(points, out currentPoints))
                                            {
                                                currentPoints += goalPoints;
                                                points = currentPoints.ToString();
                                                if (completedTimes == maxTimes)
                                                {
                                                    int bonus = int.Parse(parts[7]);
                                                    currentPoints += bonus;
                                                    points = currentPoints.ToString();
                                                    parts[1] = "[X]";
                                                    Console.WriteLine($"Congrats you met your goal! You gained the {bonus} bonus points!");
                                                }
                                            }
                                        }
                                    }
                                    // Update the goal entry
                                    listOfGoals[index] = string.Join(":", parts);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Returning to Menu...");
                    }
                    break;

                case "6":
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please Enter a number from 1-6");
                    break;
            }
        }
    }

    static string ProcessGoal(string goal)
    {
        // Split the goal into its parts
        string[] parts = goal.Split(':');

        // Determine the type of goal
        string goalType = parts[0];

        // Process based on goal type
        switch (goalType)
        {
            case "Simple Goal":
                // For simple goals, exclude the goal type and the points
                if (parts.Length >= 5)
                {
                    string completedStatus = parts[1].Trim();
                    string goalName = parts[2].Trim();
                    string goalDescription = parts[3].Trim();
                    return $"{completedStatus} {goalName} {goalDescription}";
                }
                break;
            case "Eternal Goal":
                if (parts.Length >= 5)
                {
                    string completedStatus = parts[1].Trim();
                    string goalName = parts[2].Trim();
                    string goalDescription = parts[3].Trim();
                    return $"{completedStatus} {goalName} {goalDescription}";
                }
                break;
            case "Checklist Goal":
                if (parts.Length >= 8)
                {
                    string completedStatus = parts[1].Trim();
                    string goalName = parts[2].Trim();
                    string goalDescription = parts[3].Trim();
                    string timesCompleted = parts[5].Trim();
                    string maxTimes = parts[6].Trim();
                    return $"{completedStatus} {goalName} {goalDescription} -- Completed {timesCompleted}/{maxTimes}";
                }
                break;
            default:
                return goal;
        }

        return string.Empty;
    }
}