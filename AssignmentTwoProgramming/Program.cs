//  Step 1:
//  Prompting a user for the number of contestants who entered last year's competition and this year’s competition.
//  The user must enter a number between 0 and 30, inclusive, for the number of contestants each year.
//  If the user enters an incorrect number, the program prompts for a valid value.

// Step 2:
// Displaying all the input data.

// Step 3:
// Display the statement that shows a statistic of contestants attending.

//Case 1: If the competition has more than twice as many contestants as last year, display 'The competition is more than twice as big this year!'
//Case 2: If the competition is equal to or bigger than last year’s but not more than twice as big, display 'The competition is bigger than ever!'
//Case 3: If the competition is smaller than last year’s, display 'A tighter race this year! Come out and cast your vote!'

using System;

using static System.Console;

class QueenslandRevenue
{
    static void Main()
    {
        // Step 1
        int LastYearContestantsNum;
        int ThisYearContestantsNum;

        Console.WriteLine("Please enter last year contestants number participated in the competitions - (Number should be between 0 and 30): ");
        LastYearContestantsNum = Convert.ToInt32(Console.ReadLine());

        if (!(LastYearContestantsNum >= 0 && LastYearContestantsNum <= 30))
            Console.WriteLine("A valid contestants number should be between 0 and 30"); 
        else
        {
            Console.WriteLine("Please enter the number of contestants this year - (Again, number should be between 0 and 30: ");
            ThisYearContestantsNum = Convert.ToInt32(Console.ReadLine());
            

            if (!(ThisYearContestantsNum >= 0 && ThisYearContestantsNum <= 30))
                Console.WriteLine("A valid contestants number should be between 0 and 30");

            // Step 2
            Console.WriteLine("The number of contestants last year is: {0} contestants.",LastYearContestantsNum);
            Console.WriteLine("The number of contestants this year is: {0} contestants.", ThisYearContestantsNum);

            // Step 3

        }
    }
}
