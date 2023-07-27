using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    internal class GameEventManager
    {
        // a new delegate type called GameEvent
        public delegate void GameEvent();

        // crete two delegate variables called OnGameStart and OnGameOver
        public static GameEvent OnGameStart, OnGameOver;

        // a static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            // check if the OnGameStart event is not empty,
            // meaning that other methods already subscribed to it
            if (OnGameStart != null)
            {
                // print a simple message
                Console.WriteLine("The game has started....");
                // call the OnGameStart that will trigger al the methods subscribed to this event
                OnGameStart();
            }
        }

        public static void TriggerGameOver()
        {
            // check if the OnGameOver evenet is not empty,
            // meaning that other methods already subscribed to it
            if (OnGameOver != null)
            {
                // print a simple message
                Console.WriteLine("The game is over...");
                // cal the OnGameOver that will trigger all the methods subscribed to this event
                OnGameOver();
            }
        }
    }
}
