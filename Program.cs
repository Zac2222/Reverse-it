bool runAgain = true;
    while(runAgain == true)
    {
        int number = 0;
        int reversedNum = 0;
        bool isNumber;
        int remainder;
        string reversedString = "";

        Console.WriteLine("Please enter a number to reverse it");
        do
        {
        isNumber = int.TryParse(Console.ReadLine(), out number);
        if(isNumber == false)
        {
            Console.WriteLine("Please enter a valid number!");
        }
        }while(isNumber == false);

        for(int i; number > 0; number = number / 10)
        {
            remainder = number % 10;

            reversedNum = (reversedNum * 10) + remainder;
        }
        Console.WriteLine($"The reverse is: {reversedNum}");




        Console.WriteLine("Now enter a word to reverse it");
        string myWord = Console.ReadLine();

        for(int i = myWord.Length - 1; i >= 0; i--)
        {
            reversedString += myWord[i];
        }
        Console.WriteLine($"The reverse is: {reversedString}");



        string choice = "";
	    Console.WriteLine("Would you like to run again? (y/n)");
        while(choice != "yes" & choice != "y" & choice != "no" & choice != "n")
        {
            choice = Console.ReadLine().ToLower();
        }
        
        if(choice == "y" || choice == "yes")
        {
            runAgain = true;
        }
        else if(choice == "n" || choice == "no")
        {
            runAgain = false;
            Console.WriteLine("Now exiting");
        }
    }