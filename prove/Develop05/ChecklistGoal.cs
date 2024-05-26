namespace EternalQuest
{
    // ChecklistGoal class
    public class ChecklistGoal : Goal
    {
        public int Target { get; private set; }
        public int Count { get; set; }
        public int BonusPoints { get; private set; }

        public ChecklistGoal(string name, int points, int target, int bonusPoints) : base(name, points)
        {
            Target = target;
            Count = 0;
            BonusPoints = bonusPoints;
        }

        public override void RecordEvent()
        {
            if (Count < Target)
            {
                Count++;
                Console.WriteLine($"Recorded progress for '{Name}'. Total records: {Count}/{Target}. You earned {Points} points.");
                if (Count == Target)
                {
                    Console.WriteLine($"Congratulations! You completed the checklist goal '{Name}' and earned a bonus of {BonusPoints} points.");
                }
            }
            else
            {
                Console.WriteLine($"Goal '{Name}' is already completed.");
            }
        }

        public override string GetStatus()
        {
            return Count >= Target ? $"[X] {Name} - Completed {Count}/{Target} times" : $"[ ] {Name} - Completed {Count}/{Target} times";
        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal:{Name},{Points},{Target},{Count},{BonusPoints}";
        }
    }
}