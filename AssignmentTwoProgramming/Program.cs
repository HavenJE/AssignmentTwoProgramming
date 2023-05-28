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
        int x;

        string[] NamesOfTalents = new string[4];
        string[] UserNamesInputs = new string[4];
        char[] ContestantTalent = new char[4];
        char response= '-';

        Dictionary<char, List<string>> participantsWithTalentCodes = new Dictionary<char, List<string>>
        {
            {'S', new List<string>() },
            {'D', new List<string>() },
            {'M', new List<string>() },
            {'O', new List<string>() }
        };


        // Step 1
        Console.WriteLine("Step 1"); 

        Console.WriteLine("Please enter the number of contestants participated in the competitions last year - (Number should be between 0 and 30): ");

        // Validate the input must be an integer and withing the specified range
        if (!(int.TryParse(Console.ReadLine(),out LastYearContestantsNum) 
            &&  LastYearContestantsNum >= 0
            && LastYearContestantsNum <= 30))
            Console.WriteLine("A valid contestants number should be between 0 and 30 inclusive. Please try again: ");
        else
        {
            Console.WriteLine("Please enter the number of contestants participated this year - (Again, number should be between 0 and 30: ");

            if (!(int.TryParse(Console.ReadLine(), out ThisYearContestantsNum) 
                && ThisYearContestantsNum >= 0 
                && ThisYearContestantsNum <= 30))
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
                    (ThisYearContestantsNum >= LastYearContestantsNum 
                    || ThisYearContestantsNum  <= (2 * LastYearContestantsNum))
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
                var input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input))
                {
                    UserNamesInputs[x] = Convert.ToString(input);
                }
                
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
            for (x = 0; x < ContestantTalent.Length;)
            {
                Console.WriteLine("Please indicate ({0})'s type of talent using the codes below: ", UserNamesInputs[x]);
                Console.WriteLine("S for singing, D for dancing, M for playing a musical instrument or O for other.");

                var input = Console.ReadLine();
                var inputChar= '-';
                if (!string.IsNullOrEmpty(input) && input.Length ==1 )
                {
                    inputChar = Convert.ToChar(input);
                }
                

                if (inputChar == 'S' || inputChar == 'D' || inputChar == 'M' || inputChar == 'O')
                {                   
                    participantsWithTalentCodes[inputChar].Add(UserNamesInputs[x]); 
                    ContestantTalent[x] = inputChar;
                    x += 1;
                }
                else
                {
                    Console.WriteLine("You entered the wrong talent code! ({0}) \n", inputChar);                   
                }
             
            }

            foreach (var key in participantsWithTalentCodes.Keys)
            {
                var values = string.Join(',', participantsWithTalentCodes[key]);
                Console.WriteLine("You attached the talents: {0} to the contestant: {1}", key, values);
            }

            // Step 5
            Console.WriteLine("Step 5");

            Console.WriteLine("Select one of the talent codes (S, D, M, O) to know the count or type Y to stop: ");
            while (true)
            {
                var matchingKey = '-';
                var question = Console.ReadLine();
                if (!string.IsNullOrEmpty(question) && question.Length == 1)
                {
                    response = Convert.ToChar(question);
                }

                foreach (var key in participantsWithTalentCodes.Keys)
                {
                    if (key == response)
                    {
                        matchingKey = key;
                        break;
                    }
                }
                if(matchingKey != '-')
                {
                    var values = string.Join(',', participantsWithTalentCodes[matchingKey]);
                    Console.WriteLine("Count for the talents {0} ", participantsWithTalentCodes[matchingKey].Count);
                    Console.WriteLine("Names with the key {0} are {1} ", matchingKey, values);
                }
                else if(response != 'Y') {
                    Console.WriteLine("You have entered the wrong code!");
                    Console.WriteLine("Select one of the talent codes (S, D, M, O) to know the count or type Y to stop: ");
                }

                //When the user hit Y, Then exist the loop
                if (response == 'Y')
                    break;
            }

            Console.WriteLine("Count of the talents are {0}", UserNamesInputs.Length);

        }
    }
}
