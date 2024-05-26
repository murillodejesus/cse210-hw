using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    class GoalManager
    {
        private List<Goal> goals = new List<Goal>();
        private int totalPoints = 0;

        public void Run()
        {
            LoadGoals();
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nEternal Quest - Main Menu");
                Console.WriteLine("1. Add New Goal");
                Console.WriteLine("2. Record Goal Event");
                Console.WriteLine("3. Show Goals");
                Console.WriteLine("4. Show Score");
                Console.WriteLine("5. Save and Exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddNewGoal();
                        break;
                    case "2":
                        RecordGoalEvent();
                        break;
                    case "3":
                        ShowGoals();
                        break;
                    case "4":
                        ShowScore();
                        break;
                    case "5":
                        SaveGoals();
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private void AddNewGoal()
        {
            Console.WriteLine("Select Goal Type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string choice = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    goals.Add(new SimpleGoal(name, points));
                    break;
                case "2":
                    goals.Add(new EternalGoal(name, points));
                    break;
                case "3":
                    Console.Write("Enter target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points: ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, points, target, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }

        private void RecordGoalEvent()
        {
            Console.WriteLine("Select a goal to record an event for:");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
            }
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                Goal selectedGoal = goals[goalIndex];
                selectedGoal.RecordEvent();
                totalPoints += selectedGoal.Points;

                if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.Count == checklistGoal.Target)
                {
                    totalPoints += checklistGoal.BonusPoints;
                }
            }
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
        }

        private void ShowGoals()
        {
            Console.WriteLine("\nGoals List:");
            foreach (Goal goal in goals)
            {
                Console.WriteLine(goal.GetStatus());
            }
        }

        private void ShowScore()
        {
            Console.WriteLine($"\nTotal Score: {totalPoints} points");
        }

        private void SaveGoals()
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                writer.WriteLine(totalPoints);
                foreach (Goal goal in goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals and score saved successfully.");
        }

        private void LoadGoals()
        {
            if (File.Exists("goals.txt"))
            {
                string[] lines = File.ReadAllLines("goals.txt");
                totalPoints = int.Parse(lines[0]);

                foreach (string line in lines[1..])
                {
                    string[] parts = line.Split(':');
                    string goalType = parts[0];
                    string[] details = parts[1].Split(',');

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            SimpleGoal simpleGoal = new SimpleGoal(details[0], int.Parse(details[1]));
                            simpleGoal.IsComplete = bool.Parse(details[2]);
                            goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            EternalGoal eternalGoal = new EternalGoal(details[0], int.Parse(details[1]));
                            eternalGoal.Count = int.Parse(details[2]);
                            goals.Add(eternalGoal);
                            break;
                        case "ChecklistGoal":
                            ChecklistGoal checklistGoal = new ChecklistGoal(details[0], int.Parse(details[1]), int.Parse(details[2]), int.Parse(details[4]));
                            checklistGoal.Count = int.Parse(details[3]);
                            goals.Add(checklistGoal);
                            break;
                    }
                }
                Console.WriteLine("Goals and score loaded successfully.");
            }
        }
    }
}