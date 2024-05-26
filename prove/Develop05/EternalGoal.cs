namespace EternalQuest
{
    // EternalGoal class
    public class EternalGoal : Goal
    {
        public int Count { get; set; }

        public EternalGoal(string name, int points) : base(name, points)
        {
            Count = 0;
        }

        public override void RecordEvent()
        {
            Count++;
            Console.WriteLine($"Recorded progress for '{Name}'. Total records: {Count}. You earned {Points} points.");
        }

        public override string GetStatus()
        {
            return $"[∞] {Name} - Completed {Count} times";
        }

        public override string GetStringRepresentation()
        {
            return $"EternalGoal:{Name},{Points},{Count}";
        }
    }
}