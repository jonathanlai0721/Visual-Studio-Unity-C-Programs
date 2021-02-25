using System;
using ConsoleCards;

namespace ProgrammingAssignment2
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Nothing Like Blackjack functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK
                Deck dec1 = new Deck();
                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                Card card1_play1 = dec1.TakeTopCard();
                Card card1_play2 = dec1.TakeTopCard();
                Card card1_play3 = dec1.TakeTopCard();
                Card card1_play4 = dec1.TakeTopCard();
                Card card2_play1 = dec1.TakeTopCard();
                Card card2_play2 = dec1.TakeTopCard();
                Card card2_play3 = dec1.TakeTopCard();
                Card card2_play4 = dec1.TakeTopCard();
                // deal 1 more card to players 2 and 3
                Card card3_play2 = dec1.TakeTopCard();
                Card card3_play3 = dec1.TakeTopCard();
                // flip all the cards over
                card1_play1.FlipOver();
                card1_play2.FlipOver();
                card1_play3.FlipOver();
                card1_play4.FlipOver();
                card2_play1.FlipOver();
                card2_play2.FlipOver();
                card2_play3.FlipOver();
                card2_play4.FlipOver();
                card3_play2.FlipOver();
                card3_play3.FlipOver();
                // print the cards for player 1
                Console.WriteLine("The cards are: " + card1_play1.Rank + "of" + card1_play1.Suit + ", " + card2_play1.Rank + "of" + card2_play1.Suit);
                // print the cards for player 2
                Console.WriteLine("The cards are: " + card1_play2.Rank + "of" + card1_play2.Suit + ", " + card2_play2.Rank + "of" + card2_play2.Suit + ", " + card3_play2.Rank + "of" + card3_play2.Suit);
                // print the cards for player 3
                Console.WriteLine("The cards are: " + card1_play3.Rank + "of" + card1_play3.Suit + ", " + card2_play3.Rank + "of" + card2_play3.Suit + ", " + card3_play3.Rank + "of" + card3_play3.Suit);
                // print the cards for player 4
                Console.WriteLine("The cards are: " + card1_play4.Rank + "of" + card1_play4.Suit + ", " + card2_play4.Rank + "of" + card2_play4.Suit);
                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
