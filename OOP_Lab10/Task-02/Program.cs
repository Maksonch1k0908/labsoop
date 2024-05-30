using System.Net.NetworkInformation;

public class Program
{
    public static void Main()
    {
        King king = new King(Console.ReadLine());
        List<Soldier> soldiers = new List<Soldier>();

        string[] royalName = Console.ReadLine().Split(' ');
        string[] footmanName = Console.ReadLine().Split(' ');

        foreach (var name in royalName)
        {
            var royalGuard = new RoyalGuard(name);
            soldiers.Add(royalGuard);
            king.UnderAttack += royalGuard.RespondToAttack;
        }
        foreach (var name in footmanName)
        {
            var footman = new Footman(name);
            soldiers.Add(footman);
            king.UnderAttack += footman.RespondToAttack;
        }

        string inputCommands;
        while ((inputCommands = Console.ReadLine().ToLower()) != "end")
        {
            string[] commands = inputCommands.Split(' ');
            if (commands[0] == "attack" && commands[1] == "king")
            {
                king.OnAttack();

            }
            if (commands[0] == "kill")
            {
                string soldierName = commands[1];
                var soldier = soldiers.FirstOrDefault(s => s.Name.Equals(soldierName, StringComparison.OrdinalIgnoreCase));

                if (soldier != null)
                {
                    king.UnderAttack -= soldier.RespondToAttack;
                    soldiers.Remove(soldier);
                }
                else
                {
                    Console.WriteLine($"Soldier {soldierName} not found.");
                }
            }
        }
    }
}