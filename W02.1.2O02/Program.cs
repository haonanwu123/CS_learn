namespace W02._1._2O02;

static class Program
{
    static void Main()
    {
        /* Below is a map of 6 Locations.
         * The Player starts at 1 and the goal is to move to 6.
         * +---+
         * |123|
         * | 4 |
         * | 56|
         * +---+
         */

        Player player = new(World.Locations[0]); // Create player
        player.CurrentLocation = World.Locations[0]; // Place player at Location 1

        Console.WriteLine("Current location: " + player.CurrentLocation.Name);
        Console.WriteLine(player.CurrentLocation.Compass());
        Console.WriteLine("Location to the east: " + player.CurrentLocation.GetLocationAt("E").Name);
        player.TryMoveTo(player.CurrentLocation.GetLocationAt("E")); // Moves the Player to Location 2

        /*
         * Write a while-loop that continues until the Player has arrived at the Goal.
         * At each iteration, ask the user for a direction (N/E/S/W), then try to move the Player.
         * For example:
         * - player.TryMoveTo("N") will move the Player north IF there is a Location;
         * - player.TryMoveTo("Hello") will not move the Player;
         * - player.TryMoveTo(null) will not move the Player.
         */

        while (player.CurrentLocation.ID != World.LOCATION_ID_LOC6)
        {
            Console.WriteLine("Enter a direction (N/E/S/W)");
            string direction = Console.ReadLine()!.ToUpper();

            Location newlocation = player.CurrentLocation.GetLocationAt(direction);
            if (newlocation != null)
            {
                if (player.TryMoveTo(newlocation))
                {
                    Console.WriteLine("Move to: " + player.CurrentLocation.Name);
                    Console.WriteLine(player.CurrentLocation.Compass());
                }
                else
                {
                    Console.WriteLine("Cannot move in that direction.");
                }
            }
            else
            {
                Console.WriteLine("Invaild direction");
            }
        }

        Console.WriteLine("You have arrived at the goal!");
    }
}

