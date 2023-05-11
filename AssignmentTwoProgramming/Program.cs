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
        string UserNamesInput;
        char ContestantTalent;

        Console.WriteLine("Please enter the number of contestants participated in the competitions last year - (Number should be between 0 and 30): ");
        LastYearContestantsNum = Convert.ToInt32(Console.ReadLine());

        if (!(LastYearContestantsNum >= 0 && LastYearContestantsNum <= 30))
            Console.WriteLine("A valid contestants number should be between 0 and 30 inclusive. Please try again: ");
        else
        {
            Console.WriteLine("Please enter the number of contestants participated this year - (Again, number should be between 0 and 30: ");
            ThisYearContestantsNum = Convert.ToInt32(Console.ReadLine());

            if (!(ThisYearContestantsNum >= 0 && ThisYearContestantsNum <= 30))
                Console.WriteLine("A valid contestants number should be between 0 and 30. Please try again: ");

            else
            {
                // Step 2
                Console.WriteLine("The number of contestants last year is: {0} contestants.", LastYearContestantsNum);
                Console.WriteLine("The number of contestants this year is: {0} contestants. \n", ThisYearContestantsNum);

                // Step 3
                if (ThisYearContestantsNum > (2 * LastYearContestantsNum))
                    Console.WriteLine("The competition is more than twice as big this year!");
                else if
                    (ThisYearContestantsNum >= LastYearContestantsNum && ThisYearContestantsNum < (2 * LastYearContestantsNum))
                    Console.WriteLine("The competition is bigger than ever!");
                else 
                {
                    Console.WriteLine("A tighter race this year! Come out and cast your vote! \n");
                }
                // Step 4
                Console.WriteLine("Please enter each contestant name below: ");
                UserNamesInput = Convert.ToString(Console.ReadLine());
                // Console.WriteLine(UserNamesInput);

                Console.WriteLine("Please indicate {0}'s type of talent using the codes below: ", UserNamesInput);
                Console.WriteLine("S for singing, D for dancing, M for playing a musical instrument or O for other.");

                ContestantTalent = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(ContestantTalent);
            }

        }

       

    
    }
}
