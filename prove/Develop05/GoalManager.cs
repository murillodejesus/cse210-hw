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
                Console.WriteLine("/nEternal Quest - Main Menu");
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
                        AddRecordGoalEvent();
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

        private void AddRecordGoalEvent()
    }
}