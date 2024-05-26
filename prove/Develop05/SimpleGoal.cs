namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public bool IsComplete { get; set; }

        public SimpleGoal(string name, int points) : base(name, points)
        {
            IsComplete = false;
        }

        public override void RecordEvent()
        {
            IsComplete = true;
            Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
        }

        public override string GetStatus()
        {
            return IsComplete ? "[X] " + Name : "[ ] " + Name;
        }

        public override string GetStringRepresentation()
        {
            return $"SimpleGoal:{Name},{Points},{IsComplete}";
        }
    }
}