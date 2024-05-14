namespace Nelson.Habit_Tracker.UserConsoleInteraction
{
    public class ConsoleInteraction : IConsoleInteraction
    {
        public void DisplayMenu()
        {
            Console.WriteLine("\n\nMain Menu");
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("\nType 0 to Close Application");
            Console.WriteLine("Type 1 to View All Habits");
            Console.WriteLine("Type 2 to Insert New Habit");
            Console.WriteLine("Type 3 to Update Habit");
            Console.WriteLine("Type 4 to Delete Habit");
            Console.WriteLine("----------------------------------------\n");
        }
    }
}