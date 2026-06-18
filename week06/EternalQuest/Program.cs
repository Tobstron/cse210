class Program
{
    static void Main(string[] args)
    {
        /*
         * Creativity:
         * Added score tracking system.
         * Added leveling system based on points.
         * Goals can be saved and loaded from files.
         */

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}