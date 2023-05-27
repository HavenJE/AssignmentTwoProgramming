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

        int LastYearContestantsNum;
        int ThisYearContestantsNum;   
        int TalentCount =0;
        int x;

        string[] NamesOfTalents = new string[4];
        string[] UserNamesInputs = new string[4];
        char[] ContestantTalent = new char[4];
        char response;
    
        bool talentCode = true;
        // Step 1
        Console.WriteLine("Step 1"); 

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
                Console.WriteLine("Step 2");

                Console.WriteLine("The number of contestants last year is: {0} contestants.", LastYearContestantsNum);
                Console.WriteLine("The number of contestants this year is: {0} contestants. \n", ThisYearContestantsNum);

                // Step 3
                Console.WriteLine("Step 3");
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
            Console.WriteLine("Step 4");
            // promote user to enter contestant name 
            for (x = 0; x < UserNamesInputs.Length; ++x)
            {
                Console.WriteLine("Please enter the name(s) of the {0} contestants for this year: \n", ThisYearContestantsNum);
                Console.WriteLine("Contestant number: {0}", (x + 1));
                UserNamesInputs[x] = Convert.ToString(Console.ReadLine());
                // Console.WriteLine(UserNamesInputs[x]);

            }
            for (x = 0; x < UserNamesInputs.Length; ++x)
            {
                if (UserNamesInputs.Length != 4)
                {
                    Console.WriteLine("The number of names entered is {0}", UserNamesInputs.Length); 
                }
                else
                {
                    Console.WriteLine("You successfully entered the name: {0}\n", UserNamesInputs[x].ToString());
                    // Console.WriteLine("And the talent is: {0}\n", ContestantTalent[x].ToString());
                }
            }
            // promote user to enter talent code 
            for (x = 0; x < ContestantTalent.Length; ++x)
            {
                Console.WriteLine("Please indicate ({0})'s type of talent using the codes below: ", UserNamesInputs[x]);
                Console.WriteLine("S for singing, D for dancing, M for playing a musical instrument or O for other.");

                ContestantTalent[x] = Convert.ToChar(Console.ReadLine());
                
                if (ContestantTalent[x] == 'S' || ContestantTalent[x] == 'D' || ContestantTalent[x] == 'M' || ContestantTalent[x] == 'O')
                {
                    Console.WriteLine("Please repeat the code again to confirm...");
                    ContestantTalent[x] = Convert.ToChar(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("You entered the wrong talent code! ({0}) \n", ContestantTalent[x]);                  
                    x--;
                }
            }

            for (x = 0; x < ContestantTalent.Length; ++x)
            {
                if (ContestantTalent.Length == null)
                {
                    Console.WriteLine("The number of talents entered is {0}", ContestantTalent.Length);
                }
                else
                {
                    Console.WriteLine("You attached the talents: {0} to the contestant: {1}", ContestantTalent[x].ToString(), UserNamesInputs[x].ToString());
                }
            }

            // Step 5
            Console.WriteLine("Step 5");

            Console.WriteLine("Select one of the talent codes (S, D, M, O) to know the count or type Y to stop: ");
            response = Convert.ToChar(Console.ReadLine()) ;

            for (x = 0; x < ContestantTalent.Length; ++x)
            {
                if (response == ContestantTalent[x] && (talentCode = true))
                {
                    // StringResponse = Convert.ToString(ContestantTalent[x]); 
                    TalentCount++;
                }
                else if (response == 'Y')
                {
                    talentCode = false;
                }                 
            }

            if (talentCode = true && response != 'Y')
            {
                Console.WriteLine("For the ({0}) contensts of this year competition: ", ThisYearContestantsNum);
                Console.WriteLine("The count is ({0}) for talent ({1})", TalentCount, response);
            }
            else if (talentCode == false)
            {
                // Console.WriteLine(UserNamesInputs[x]);
                Console.WriteLine("We have ({0}) contestants this year and we hope to see you in next year competition!");
            }
            else 
            {
                Console.WriteLine("The code is not valid!");
                Console.WriteLine("Select one of the talent codes (S, D, M, O) to know the count or type Y to stop:");
            }
            // NamesOfTalents = UserNamesInputs[x].Select(x => x.ToString()).ToArray();

        }
    }
}
