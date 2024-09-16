using System.ComponentModel;

int points = 0;
Console.WriteLine("Hej och välkommen till ditt livs viktigaste spel.");
Console.ReadLine();
Console.WriteLine("Att svara rätt på dessa frågor är LIVSVIKTIGT");
Console.ReadLine();
Console.WriteLine("Den första frågan är väldigt simpel... Vad är ditt namn, unga själ?");
string name = Console.ReadLine();

Console.WriteLine($"Välkommen till vad som kan vara ditt livs sista men definitivt viktisgaste spel, kära {name}.");
Console.ReadLine();
Console.WriteLine("För att lämna detta spel med ditt liv så är det ytterst viktigt att du får åtminstone 50% rätt.");
Console.ReadLine();

Console.WriteLine($"Här kommer första frågan {name}. är du redo?");
Console.ReadLine();
Console.WriteLine("Fråga nr 1: I vilket land ligger paris. A, Ryssland. B, Spanien. C, Belgien. D, Frankrike.");
string answer = Console.ReadLine(); 
if (answer.ToLower() == "d")
{
    points++;
    Console.WriteLine($"Grattis {name}, du fick din första fråga rätt.");
    Console.ReadLine();
}
else
{
    Fel();
    Console.WriteLine("AJ, det gör ont för mig att se sådana patetiska misslyckande.");
    Console.ReadLine();
}
//------------------------------------------------------




static void Fel()
{
    Console.WriteLine("""
            
       ______________________.____    ._.
       \_   _____/\_   _____/|    |   | |
        |    __)   |    __)_ |    |   | |
        |     \    |        \|    |___ \|
        \___  /   /_______  /|_______ \__
            \/            \/         \/\/

    """);
}