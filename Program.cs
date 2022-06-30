

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"What is the name of the levitation spell?");

        var spellName = Console.ReadLine();
        
        Console.WriteLine($"It's leviOsa, not {spellName}!");
    }
}