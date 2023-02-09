 Random rnd = new Random();
            int targetNumber = rnd.Next(1, 10);
            int userGuess = 0;

            while(userGuess != targetNumber)
            {
                Console.WriteLine("Enter a number between 1 - 10");
                userGuess = Int16.Parse(Console.ReadLine());
                if (userGuess < targetNumber)
                {
                    Console.WriteLine("Your guess is too low\n");
                }
                else if(userGuess > targetNumber)
                {
                    Console.WriteLine("Your guess is too high\n");
                }
            }
            Console.WriteLine($"Congratulations, your guess of {userGuess} was correct");
            Console.ReadLine();