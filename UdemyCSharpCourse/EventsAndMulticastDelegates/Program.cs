namespace EventsAndMulticastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an audio system
            AudioSystem audioSystem = new AudioSystem();
            // create a rendering engine
            RenderingEngine renderingEngine = new RenderingEngine();
            // create two players and give them Id's
            Player player1 = new Player("IronMarmot");
            Player player2 = new Player("SqueakySnake");
            Player player3 = new Player("DragonKitten");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running....Press any key to end the game. ");

            // pause console
            Console.ReadKey();

            GameEventManager.TriggerGameOver();

        }
    }
}