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

// Step 4:
// After the user enters the number of contestants in this year’s competition, the user is prompted to enter the appropriate number of contestant
// names and a code for each contestant that indicates the type of talent:
// S for singing,
// D for dancing,
// M for playing a musical instrument or
// O for other.
// Make sure that all entered codes are valid, and if not, re-prompt the user to enter a correct code.

using System;
class QueenslandRevenue
{
    static void Main()
    {
        // Step 1
        int LastYearContestantsNum;
        int ThisYearContestantsNum;
        int x;
       
        string[] UserNamesInputs = new string[4];
        char[] ContestantTalent = { 'S', 'D', 'M', 'O' };
        char SINGING = 'S';
        char DANCING = 'D';
        char MUSICAL = 'M';
        char OTHER = 'O';
        

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
                    Console.WriteLine("The competition is more than twice as big this year! \n");
                else if
                    (ThisYearContestantsNum >= LastYearContestantsNum || ThisYearContestantsNum  <= (2 * LastYearContestantsNum))
                    Console.WriteLine("The competition is bigger than ever! \n");
                else if 
                    (ThisYearContestantsNum < LastYearContestantsNum)
                {
                    Console.WriteLine("A tighter race this year! Come out and cast your vote! \n");
                }
            }
            // Step 4
            for (x = 0; x < UserNamesInputs.Length; ++x)
            {
                Console.WriteLine("Please enter the name(s) of the {0} contestants for this year: \n", ThisYearContestantsNum);
                Console.WriteLine("Contestant number: {0}", (x + 1));
                UserNamesInputs[x] = Convert.ToString(Console.ReadLine());
                // Console.WriteLine(UserNamesInputs[x]);
                // x++;
            }
            for (x = 0; x < UserNamesInputs.Length; ++x)
            {
                // Console.WriteLine(UserNamesInputs[x].ToString());
                x = ThisYearContestantsNum;
            }
            // Console.ReadLine(); 
            Console.WriteLine("{0, 3}", UserNamesInputs[x].ToString());
        }   
    }
}


//Console.WriteLine("Please enter each contestant name below: ");
//UserNamesInputs = Convert.ToString(Console.ReadLine());
//// Console.WriteLine(UserNamesInputs);

//Console.WriteLine("Please indicate {0}'s type of talent using the codes below: ", UserNamesInputs);
//Console.WriteLine("S for singing, D for dancing, M for playing a musical instrument or O for other.");

//ContestantTalent = Convert.ToChar(Console.ReadLine());
//Console.WriteLine(ContestantTalent);

//if (!(ContestantTalent == SINGING || ContestantTalent == DANCING || ContestantTalent == MUSICAL || ContestantTalent == OTHER))
//{
//    Console.WriteLine("Please enter one of the correct codes below :");
//    Console.WriteLine("S for singing, D for dancing, M for playing a musical instrument or O for other.");
//    ContestantTalent = Convert.ToChar(Console.ReadLine());
//}
//else
//{

//}