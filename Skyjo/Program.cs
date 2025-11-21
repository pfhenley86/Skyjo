namespace Skyjo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***
             * Deck **
             */
            
            //Build The Deck into a List holding all the cards in the game -- maybe half for a one player game
            List<int> deck = new List<int>();
            
            /***
             * Cards **
             */
            
            //Negative two cards - 5
            int[] negativeTwoCards = [-2, -2, -2, -2, -2];
            
            //Zero cards - 15
            int[] zeroCards = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
            
            //Negative one cards - 10
            int[] negativeOneCards = [-1, -1, -1, -1, -1, -1, -1, -1, -1, -1];
            
            //One cards - 10
            int[] oneCards = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1];
            
            //Two cards - 10
            int[] twoCards = [2, 2, 2, 2, 2, 2, 2, 2, 2, 2];
            
            //Three cards - 10
            int[] threeCards = [3, 3, 3, 3, 3, 3, 3, 3, 3, 3];
            
            //Four cards - 10
            int[] fourCards = [4, 4, 4, 4, 4, 4, 4, 4, 4, 4];
            
            //Five cards - 10
            int[] fiveCards = [5, 5, 5, 5, 5, 5, 5, 5, 5, 5];
            
            //Sixe cards - 10
            int[] sixCards = [6, 6, 6, 6, 6, 6, 6, 6, 6, 6];
            
            //Seven cards - 10
            int[] sevenCards = [7, 7, 7, 7, 7, 7, 7, 7, 7, 7];
            
            //Eight cards - 10
            int[] eightCards = [8, 8, 8, 8, 8, 8, 8, 8, 8, 8];
            
            //Nine cards - 10
            int[] nineCards = [9, 9, 9, 9, 9, 9, 9, 9, 9, 9];
            
            //Ten cards - 10
            int[] tenCards = [10, 10, 10, 10, 10, 10, 10, 10, 10, 10];
            
            //Eleven cards - 10
            int[] elevenCards = [11, 11, 11, 11, 11, 11, 11, 11, 11, 11];
            
            //Twelve cards - 10
            int[] twelveCards = [12, 12, 12, 12, 12, 12, 12, 12, 12, 12];

            
            /***
             * Add Cards to Deck **
             */
            deck.AddRange(negativeOneCards);
            deck.AddRange(zeroCards);
            deck.AddRange(negativeTwoCards);
            deck.AddRange(oneCards);
            deck.AddRange(twoCards);
            deck.AddRange(threeCards);
            deck.AddRange(fourCards);
            deck.AddRange(fiveCards);
            deck.AddRange(sixCards);
            deck.AddRange(sevenCards);
            deck.AddRange(eightCards);
            deck.AddRange(nineCards);
            deck.AddRange(tenCards);
            deck.AddRange(elevenCards);
            deck.AddRange(twelveCards);
            
            Console.WriteLine(deck.Count);

            /****
             * Shuffle The Deck by randomizing the array
             ****/
            
            // Shuffle using Fisher-Yates algorithm
            Random rng = new Random();
            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1); // random index between 0 and i
                int temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }

            // Add shuffled numbers back to the list (duplicates original content)
            deck.AddRange(deck);

            // Print result
            Console.WriteLine(string.Join(", ", deck));

            /***
             * Deal 12 Cards to the user into an array
             */

            //Assign 12 cards to user in an array 

            //Randomize the order of the desk to simulated laying out your cards on the table

            //Print deck to the console in a 4 x 3 matrix of 12 cards displaying the cards as an x to represent the back of the card

            /**** Start The Loop ***/

            //Ask user to pick a card from deck or or to flip a card in their hand

            //The user picks an index in their deck array and then the deck is printed to the console to reveal their card number

            /**** Repeat The Loop Until all 12 cards are revealed -- possibly add a way to take cards from the deck to change out the array ***/

            //Total the cards and print the users point total to the console


        }
    }
}
