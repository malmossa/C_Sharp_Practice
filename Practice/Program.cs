using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            ChestState currentState = ChestState.Locked;

            while (true)
            {
                Console.Write($"The chest is {currentState}. What do you want to do? ");
                string userInput = Console.ReadLine();

                if(currentState == ChestState.Locked && userInput == "unlock") 
                {
                    currentState = ChestState.Closed;
                }

                if(currentState == ChestState.Closed && userInput == "open")
                {
                    currentState = ChestState.Open;
                }

                if(currentState == ChestState.Open && userInput == "close") 
                {
                    currentState = ChestState.Closed;
                }

                if(currentState == ChestState.Closed && userInput == "lock")
                {
                    currentState = ChestState.Locked;
                }
            }
           
        }

        enum ChestState { Open, Closed, Locked }

    }

    
}





