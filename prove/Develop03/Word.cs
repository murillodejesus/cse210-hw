class ScriptureMemorizer
{
    private readonly Scripture _scripture;

    public ScriptureMemorizer(Scripture scripture)
    {
        _scripture = scripture;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine("Press enter to hide words. Type 'quit' to exit.");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine(_scripture.GetDisplayText());

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            _scripture.HideWords();
        }
    }
}
