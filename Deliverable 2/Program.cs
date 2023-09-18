Console.WriteLine("Welcome to COIN FLIP CHALLLENGE!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine  ("Welcome " + name + " Do you want to do the COIN FLIP CHALLENGE? [Yes,No]");
string answer = Console.ReadLine().Trim().ToLower();
if (answer == "no")
{
    Console.WriteLine("You are a coward " + name + " !");
}
else
{
    int value = 0;
    int total = 0;
    int coin;
    string userInput;
    string coinDescription;
    Random rng = new Random();
  
     
       
        {
            Console.WriteLine("whats is your guess? heads or tails?");
            userInput = Console.ReadLine();

            coin = rng.Next(0, 2);

            if (coin == 0)
            {
                coinDescription = "heads";

            }
            else
            {
                coinDescription = "tails";
            }

            if ((coin == 0 && userInput == "heads") || (coin == 1 && userInput == "tails"))
            {
                Console.WriteLine("The coin was {0}, you won", coinDescription);


            }
            else
            {
                Console.WriteLine("the coin was {0}, you lost.", coinDescription);
            }
        }
        }
    


    
